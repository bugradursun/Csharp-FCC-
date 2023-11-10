//CALİSAN APP.JS Degisme: 
import React, { useState } from 'react';
import axios from 'axios';
import './styles.css'

function App() {
  const [selectedFile, setSelectedFile] = useState(null);

  const handleFileChange = (e) => {
    setSelectedFile(e.target.files[0]);
  };

  const handleUpload = async () => {
    if(!selectedFile) {
      console.error("No file Selected.")
      return;
    }

    const formData = new FormData()
    formData.append('file',selectedFile)

    try {
      const response = await axios.post('http://localhost:5000/upload', formData, {
        responseType:'blob', //binary data--pdf
      });

      const pdfBlob = new Blob([response.data],{type:'application/pdf'}) //created from binary data received in Axios response.
      const pdfUrl = URL.createObjectURL(pdfBlob) //create DOM string to represent url
      window.open(pdfUrl,'_blank') //blank : open url in new window

      // Handle the response (open/download the modified PDF)
      //console.log(response);

    } catch (error) {
      console.error('Error uploading file:', error);
    }
  };

  return (
    <div className="container">
      <div className="header">Welcome To Cropto!</div>
      <div className="content">
        <div className="input-field">
          <input type="file" name="file" id="file" onChange={handleFileChange} />
        </div>
        <button className="btn" onClick={handleUpload}>Upload & Modify PDF</button>
      </div>
      <div className="footer">
      <img src='Cropto.png' alt="Cropto"></img>
        <p>Cropto Invoice Management System</p>
        <p>Contact us:bugra.dursun@cropto.io</p>
        
      </div>
    </div>
  );
};

export default App;

------------app.py:---------------------
  from flask import Flask, render_template,request,send_file
from flask_cors import CORS
from werkzeug.utils import secure_filename
import os
import subprocess

app = Flask(__name__)
CORS(app)
app.config['UPLOAD_FOLDER'] = 'uploads'
app.config['MODIFIED_FOLDER'] = 'modified'

@app.route('/')
def index() :
    return render_template('index.html')

@app.route('/upload',methods = ['POST'])
def upload():
    if 'file' not in request.files:
        return "No file"
    file = request.files['file']
    if(file.name == '') :
        return "No selected file"
    
    if file:
        filename = secure_filename(file.filename)
        file_path = os.path.join(app.config['UPLOAD_FOLDER'],filename)
        file.save(file_path)

        subprocess.run(['python', 'C:/Users/bugra/Desktop/cs50w-Projects/Project1/CroptoPDFWeb/extractTestFinal.py', file_path]) ##convert yaptigimiz methodu executing
        modified_filename = 'modified_' + filename
        modified_path = os.path.join(app.config['MODIFIED_FOLDER'], modified_filename)
        return send_file(modified_path,as_attachment=True)
    
if __name__ == '__main__':
    app.run(debug=True)


