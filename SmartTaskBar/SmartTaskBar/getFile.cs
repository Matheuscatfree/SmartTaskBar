using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartTaskBar
{
    /// <summary>
    /// catch a determined item and then return, with the returnFile method
    /// </summary>
    /// <typeparam name="T">Type of the file item</typeparam>
    
    public class getFile<T>
    {
        /// <summary>
        /// this guy will save inially two languages(remember to implement a xml file and read the trnaslation files)
        /// </summary>
        Dictionary<string,string> dic = new Dictionary<string,string>(); 
        private void useDialog() {
            OpenFileDialog dialog = new OpenFileDialog();
            
        }

        private void withoutDialog()
        {
            throw new System.NotImplementedException();
        }

        public T returnFile(T tipo) {
            throw new System.NotImplementedException();
        }

        public getFile(string Location,bool useDialogs = false) {
            if (useDialogs == false)
            {
                withoutDialog();
                return;
            }
            else {
                useDialog();
                return;
            }
        }
    }
}