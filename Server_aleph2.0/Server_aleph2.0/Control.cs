using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;


namespace Server_aleph_2
{

    [XmlRoot("Book")]
    public class Book
    {
        string _NameBook;
        string _WhoWrote;
        string _Description;
        string _Borrow;

        [XmlAttribute("NameBook")]
        public string NameBook
        {
            get { return _NameBook; }
            set { _NameBook = value; }
        }

        [XmlElement("WhoWrote")]
        public string WhoWrote
        {
            get { return _WhoWrote; }
            set { _WhoWrote = value; }
        }

        [XmlElement("Description")]
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        [XmlElement("Borrow")]
        public string Borrow
        {
            get { return _Borrow; }
            set { _Borrow = value; }
        }
    }

    [XmlRoot("Library")]
    public class Library
    {
        List<Book> _ListBooks;

        public List<Book> ListBook
        {
            get { return _ListBooks; }
            set { _ListBooks = value; }
        }
    }




    class Control
    {
        public static Library info = new Library();
        

        public string SearchBook(string name)
        {
            Book foundBook  = info.ListBook.Find(x => x.NameBook == name);
            if (foundBook == null)
                return "brak ksiazki w kolekcji";
            if( foundBook.Borrow == "nie")  
                return "ksiazka jest juz wypozyczona";
            foundBook.Borrow = "nie";
            window_server.Grid();
            return "tak";
        }

        public string BackBook(string name)
        {
            Book foundBook = info.ListBook.Find(x => x.NameBook == name);
            if (foundBook == null)
                return "brak ksiazki w kolekcji";
            if (foundBook.Borrow == "tak")
                return "ksiazka jest oddana";
            foundBook.Borrow = "tak";
            window_server.Grid();
            return "tak";
        }

        public void ReadLibrary(string FileXML)
        {
            TextReader tr = new StreamReader(FileXML);
            XmlSerializer sr = new XmlSerializer(typeof(Library));
            if(info.ListBook != null)
                info.ListBook.Clear();
            info = (Library)sr.Deserialize(tr);
            tr.Close();
        }

        public void SaveLibrary(string FileXML)
        {
           

            File.Copy(FileXML, FileXML + "kopia", true);
            XmlTextWriter save_info = new XmlTextWriter(FileXML, null);
            save_info.Formatting = Formatting.Indented;
            save_info.Indentation = 4;
            save_info.WriteStartDocument();
            save_info.WriteStartElement("Library");
                save_info.WriteStartElement("ListBook");
                foreach (var index in info.ListBook) 
                 {
                     save_info.WriteStartElement("Book");
                         save_info.WriteAttributeString("NameBook", index.NameBook);
                            save_info.WriteStartElement("WhoWrote");
                                save_info.WriteString(index.WhoWrote);
                            save_info.WriteEndElement();
                            save_info.WriteStartElement("Description");
                                save_info.WriteString(index.Description);
                            save_info.WriteEndElement();
                            save_info.WriteStartElement("Borrow");
                                save_info.WriteString(index.Borrow);
                            save_info.WriteEndElement();
                       save_info.WriteEndElement();
                     
                            
                 }
                save_info.WriteEndElement();
             save_info.WriteEndElement();
             save_info.WriteEndDocument();
             save_info.Close();
        }

        public void AddNewBook(string name, string Who, string Des, string Borr)
        {
            if (name.Length != 0)
            {
                info.ListBook.Add(new Book() { NameBook = name, WhoWrote = Who, Description = Des, Borrow = Borr});
                window_server.Log("Dodano nową pozycje");
            }else
                 window_server.Log("Nie doddano nowej pozycji!");
            window_server.Grid();
        }

        public void RemoveBook(string name)
        {
            Book foundBook = info.ListBook.Find(x => x.NameBook == name);
            if (foundBook != null)
            {
                info.ListBook.Remove(foundBook);
                window_server.Log("Usunięto pozycje: " + name );
            }else
                 window_server.Log("Nie można usunąć pozycji: " + name);

            window_server.Grid();
            
        }

        
    }
}
