using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextFormatLib
{
    public class TextFormatOptions
    {
        private string _input;

        public bool setInput(string inputString)
        {
            if (inputString == null)
                return false;
            else
            {
                _input = inputString;
                return true;
            }
        }

        public string getCurrentInput()
        {
            if (_input != null)
                return _input;
            else
                return "";
        }

        public bool CapitalizeInput()
        {
            if (getCurrentInput() != null && getCurrentInput() != string.Empty)
            {
                string updatedInput = getCurrentInput().ToUpper();
                setInput(updatedInput);
                return true;
            }
            else
                return false;
        }

        public int NumberOfLinesInInput()
        {
            int LinesCount = 0;
            if (_input != null)
            {
                LinesCount = getCurrentInput().Split('\n').Count();
            }

            return LinesCount;
        }

        public void UpdateEachLineWithSpecificStartString(string StartWith)
        {
            string[] splitStringByLine = getCurrentInput().Split('\n');
            string UpdatedInput = string.Empty;
            string currentLine;
            foreach (string line in splitStringByLine)
            {
                UpdatedInput.Trim();
                currentLine = line.Trim();
                UpdatedInput += StartWith + currentLine + Environment.NewLine;
            }
            setInput(UpdatedInput.Trim());
        }

        public void UpdateEachLineWithSpecificEndString(string EndWith)
        {
            string[] splitStringByLine = getCurrentInput().Split('\n');
            string UpdatedInput = string.Empty;
            string currentLine;
            foreach (string line in splitStringByLine)
            {
                //char[] trimCharacters = { };
                UpdatedInput.Trim();
                currentLine = line.Trim();
                UpdatedInput += currentLine + EndWith + Environment.NewLine;
            }
            setInput(UpdatedInput.Trim());
        }
    }
}
