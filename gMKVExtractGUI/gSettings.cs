﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace gMKVToolnix
{
    public class gSettings
    {
        private String _MkvToolnixPath = String.Empty;
        public String MkvToolnixPath
        {
            get { return _MkvToolnixPath; }
            set { _MkvToolnixPath = value; }
        }

        private MkvChapterTypes _ChapterType = MkvChapterTypes.XML;
        public MkvChapterTypes ChapterType
        {
            get { return _ChapterType; }
            set { _ChapterType = value; }
        }

        private Boolean _LockedOutputDirectory;
        public Boolean LockedOutputDirectory
        {
            get { return _LockedOutputDirectory; }
            set { _LockedOutputDirectory = value; }
        }

        private String _OutputDirectory;
        public String OutputDirectory
        {
            get { return _OutputDirectory; }
            set { _OutputDirectory = value; }
        }


        private static String _SETTINGS_FILE = "gMKVExtractGUI.ini";
        private String _ApplicationPath = String.Empty;

        public gSettings(String appPath)
        {
            _ApplicationPath = appPath;
        }

        public void Reload()
        {
            if (!File.Exists(Path.Combine(_ApplicationPath, _SETTINGS_FILE)))
            {
                Save();
            }
            else
            {
                using (StreamReader sr = new StreamReader(Path.Combine(_ApplicationPath, _SETTINGS_FILE), Encoding.UTF8))
                {
                    String line = String.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.StartsWith("MKVToolnix Path:"))
                        {
                            try
                            {
                                _MkvToolnixPath = line.Substring(line.IndexOf(":") + 1);
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex);
                                _MkvToolnixPath = String.Empty;
                            }
                        }
                        else if (line.StartsWith("Chapter Type:"))
                        {
                            try
                            {
                                _ChapterType = (MkvChapterTypes)Enum.Parse(typeof(MkvChapterTypes), line.Substring(line.IndexOf(":") + 1));
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex);
                                _ChapterType = MkvChapterTypes.XML;
                            }
                        }
                        else if (line.StartsWith("Output Directory:"))
                        {
                            try
                            {
                                _OutputDirectory = line.Substring(line.IndexOf(":") + 1);
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex);
                                _OutputDirectory = String.Empty;
                            }
                        }
                        else if (line.StartsWith("Lock Output Directory:"))
                        {
                            try
                            {
                                _LockedOutputDirectory = Boolean.Parse(line.Substring(line.IndexOf(":") + 1));
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine(ex);
                                _LockedOutputDirectory = false;
                            }
                        }
                    }
                }
            }
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_ApplicationPath, _SETTINGS_FILE), false, Encoding.UTF8))
            {
                sw.WriteLine(String.Format("MKVToolnix Path:{0}", _MkvToolnixPath));
                sw.WriteLine(String.Format("Chapter Type:{0}", _ChapterType));
                sw.WriteLine(String.Format("Output Directory:{0}", _OutputDirectory));
                sw.WriteLine(String.Format("Lock Output Directory:{0}", _LockedOutputDirectory));
            }
        }
    }
}