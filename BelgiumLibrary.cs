using System;

namespace Bridge
{
    public class BelgiumLibrary
    {
        private static String fileName;

        public static String ModuleFileName
        {
            get
            {
                if (fileName == null)
                {
                    if (OperatingSystem.IsMacOS())
                    {
                        fileName = "/Library/Belgium Identity Card/Pkcs11/beid-pkcs11.bundle/Contents/MacOS/libbeidpkcs11.dylib";
                    }
                    if (OperatingSystem.IsLinux())
                    {
                        if (OperatingSystem.IsX64())
                        {
                            fileName = "/usr/lib/x86_64-linux-gnu/libbeidpkcs11.so.0";
                        }
                        else
                        {
                            fileName = "libbeidpkcs11.so";

                        }
                    }
                    if (OperatingSystem.IsWindows())
                    {
                        fileName = "beidpkcs11.dll";
                    }
                }

                return fileName;
            }
            set
            {
            }
        }

    }
}
