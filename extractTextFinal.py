import jinja2
import pdfkit
import PyPDF2
from datetime import datetime
import re 
from extractText import extractVeriler

today_date = datetime.today().strftime("%d %b, %Y") ##ikinci tarih kismi icin kullanilabilir!
today_month = datetime.today().strftime("%B")

extractVeriler["duzenleme_tarihi"] = today_date
extractVeriler["islem_tutari"] = 75000 
print(extractVeriler)
context = extractVeriler


 
template_loader = jinja2.FileSystemLoader('./')
template_env = jinja2.Environment(loader = template_loader)

html_template = 'reserveFinal.html'
template = template_env.get_template(html_template)
output_text = template.render(context)

config = pdfkit.configuration(wkhtmltopdf = "C:/Program Files/wkhtmltopdf/bin/wkhtmltopdf.exe")
pdfkit.from_string(output_text,'TestDepoRezerv2.pdf',configuration=config,css="reserve.css")
