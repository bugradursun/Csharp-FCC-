from PyPDF2 import PdfReader
import re

##FATURADAKİ KELİMELERİ BURADAN ALIYORUZ => KELİMELERİ DICTIONARYDE TUTUP => HTML'E ATAYIP YENİ FORM OLUSTURUYORUZ

reader = PdfReader("Fatura.pdf")
page = reader.pages[0]
kelimeler_array= []
kelimeler = page.extract_text()
kelimeler_array.append(kelimeler)
words  = kelimeler_array[0].split() ##now storing every words of pdf in words array !!
alici_adi = words[1:5]
alici_adi = ''.join(alici_adi)
alici_adres = words[5:14]
alici_adres = ''.join(alici_adres)
alici_vergi_daire = words[16:19]
alici_vergi_daire = ''.join(alici_vergi_daire)
alici_vkn_no = words[20] ##regex yapilacak!
alici_vkn_no = ''.join(filter(str.isdigit,alici_vkn_no))
alici_fatura_no = words[30]
alici_ozellestirme_no = words[22]
alici_fatura_tarihi = words[33]
teslim_yeri = words[51]
teslim_yeri_depo = words[57:60]
teslim_yeri_depo = ' '.join(teslim_yeri_depo)
satici_adi = words[63:67] ##regex yapılacak
satici_adi = ''.join(word for word in satici_adi if not word.startswith('TL.'))

satici_adres = words[67:81]
satici_adres = ' '.join(satici_adres)
satici_vergi_daire = words[94:98]
satici_vergi_daire = ''.join(satici_vergi_daire)
satici_vkn_no = words[99]
urun_kodu_grup = words[119]
urun_cins= words[120]
urun_miktar = words[122]
urun_birim_fiyat = words[124]

extractVeriler  = {
    "alici_adi:": alici_adi,
    "alici_adres:":alici_adres,
    "alici_vergi_daire:":alici_vergi_daire,
    "alici_vkn_no:":alici_vkn_no,
    "alici_fatura_no:":alici_fatura_no,
    "alici_ozellestirme_no:":alici_ozellestirme_no,
    "alici_fatura_tarihi:":alici_fatura_tarihi,
    "teslim_yeri:":teslim_yeri,
    "teslim_yeri_depo:":teslim_yeri_depo,
    "satici_adi:":satici_adi,
    "satici_adres:":satici_adres,
    "satici_vergi_daire:":satici_vergi_daire,
    "satici_vkn_no:":satici_vkn_no,
    "urun_kodu_grup:" : urun_kodu_grup,
    "urun_cins:" : urun_cins,
    "urun_miktar:" : urun_miktar,
    "urun_birim_fiyat:" : urun_birim_fiyat

}

##print(extractVeriler["urun_miktar:"])


##print(words[5:14])
##print(alici_adres)

##WITH THIS WE CAN EXTRACT TEXTS, NEED PATTERN TO EXTRACT DETERMINED WORDS
