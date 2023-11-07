import React, { useState, useEffect } from "react";
import * as pdfjs from "pdfjs-dist"; // Import the full PDF.js library
import { PDFDocument, rgb } from "pdf-lib"; //generating new pdf
//import "pdfjs-dist/build/pdf.worker.entry"; //text layer

pdfjs.GlobalWorkerOptions.workerSrc =
  "./node_modules/pdfjs-dist/build/pdf.worker.mjs";

function UploadImage() {
  const [selectedFile, setSelectedFile] = useState(null);

  const handleFileChange = (e) => {
    // Handle the selected file here
    const file = e.target.files[0];
    if (file && file.type === "application/pdf") {
      setSelectedFile(file);
    } else {
      console.error("Please select a valid PDF file!");
    }
  };

  const extractTextFromPDF = async (pdfData, x, y, width, height) => {
    const loadingTask = pdfjs.getDocument({ data: pdfData });
    const pdf = await loadingTask.promise;
    const page = await pdf.getPage(1); //we will always modify the first page,however check the INDEX?!

    const viewport = page.getViewport({ scale: 1.0 });
    const textContent = await page.getTextContent();
    const textLayer = new pdfjs.TextLayerBuilder({
      textContent,
      container: document.querySelector("#text-layer"),
    });
    textLayer.setTextContent(textContent);
    textLayer.renderTextLayer();
    textLayer.convertToViewportRectangle({ x, y, width, height });

    const extractedText = textLayer.textDivs.map((div) => div.textContent);
    return extractedText.join("\n");
  };

  const generateNewPDF = async (extractedText) => {
    const pdfDoc = await PDFDocument.create();
    const page = pdfDoc.addPage([600, 400]);
    page.drawText(extractedText, {
      x: 50,
      y: 350,
      size: 12,
      color: rgb(0, 0, 0),
    });
    const pdfBytes = await pdfDoc.save();
    return pdfBytes;
  };

  //This logic will allow us to extract specific content from the uploadedpdf and create a new pdf with the extracted content
  //will call pdfmodification fncs here
  const handleUpload = async () => {
    // Implement the image upload logic here
    if (selectedFile) {
      console.log("Uploading file:", selectedFile);
      try {
        const pdfFile = selectedFile;
        const pdfData = await pdfFile.arrayBuffer();

        const extractedText = await extractTextFromPDF(pdfData, 40, 40, 50, 60); //extract specific content from pdf
        const newPdfBytes = await generateNewPDF(extractedText); //generate new pdf
        const blob = new Blob([newPdfBytes], { type: "application/pdf" });
        const url = URL.createObjectURL(blob);
        window.open(url, "_blank");
      } catch (error) {
        console.error("Error while handling PDF:", error);
      }
    }
  };

  return (
    <div>
      <h1>Upload Image Page</h1>
      <input type="file" accept="image/*" onChange={handleFileChange} />
      <button onClick={handleUpload}>Upload Image</button>
    </div>
  );
}

export default UploadImage;
