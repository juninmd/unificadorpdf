using System;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace UnificadorPdf
{

    public  static class RunBarry
    {
        public static string destinationfile;
        private static IList fileList = new ArrayList();



        #region Public Methods
        ///
        /// Add a new file, together with a given docname to the fileList and namelist collection
        ///
        public static void AddFile(string pathnname)
        {
            fileList.Add(pathnname);
        }
        public static void Zerar()
        {
            fileList.Clear();
        }

        ///
        /// Generate the merged PDF
        ///
        public static void Execute()
        {
            MergeDocs();
        }
        #endregion

        #region Private Methods
        ///
        /// Merges the Docs and renders the destinationFile
        ///
        private static void MergeDocs()
        {

            //Step 1: Create a Docuement-Object
            var document = new Document();
            try
            {
                //Step 2: we create a writer that listens to the document
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationfile, FileMode.Create));

                //Step 3: Open the document
                document.Open();

                PdfContentByte cb = writer.DirectContent;
                PdfImportedPage page;

                //Loops for each file that has been listed
                foreach (string filename in fileList)
                {
                    //The current file path
                    string filePath = filename;

                    // we create a reader for the document
                    PdfReader reader = new PdfReader(filePath);

                    //Gets the number of pages to process
                    var n = reader.NumberOfPages;

                    var i = 0;
                    while (i < n)
                    {
                        i++;
                        document.SetPageSize(reader.GetPageSizeWithRotation(1));
                        document.NewPage();

                        //Insert to Destination on the first page
                        if (i == 1)
                        {
                            Chunk fileRef = new Chunk(" ");
                            fileRef.SetLocalDestination(filename);
                            document.Add(fileRef);
                        }

                        page = writer.GetImportedPage(reader, i);
                        var rotation = reader.GetPageRotation(i);
                        if (rotation == 90 || rotation == 270)
                        {
                            cb.AddTemplate(page, 0, -1f, 1f, 0, 0, reader.GetPageSizeWithRotation(i).Height);
                        }
                        else
                        {
                            cb.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
                        }
                    }
                }
            }
            catch (Exception e) { throw e; }
            finally { document.Close(); }
        }
        #endregion

        #region Properties

        ///
        /// Gets or Sets the DestinationFile
        ///
        public static string DestinationFile
        {
            get { return destinationfile; }
            set { destinationfile = value; }
        }
        #endregion
    }
}
