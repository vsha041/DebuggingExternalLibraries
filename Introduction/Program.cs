using System;

namespace Introduction
{
    /// <summary>
    /// https://github.com/dotnet/core/blob/master/Documentation/diagnostics/portable_pdb.md
    /// 
    /// 1. What is the role of PDB (Symbols) file?
    /// a. Show output window.
    /// a. Delete the pdb file from bin
    /// b. Then delete the pdb file from Obj
    /// 
    /// 2. How does VS debugger finds the location of PDB file?
    /// dumpbin /headers Introduction.exe 
    ///
    /// 3. How to view Symbol load information through modules window and dumpbin command?
    /// dumpbin /PDBPATH:VERBOSE Introduction.exe
    ///
    /// 4. How does VS debugger finds the location of source files?
    /// https://drive.google.com/open?id=1hl7BkCWwSKeeQQtgWgs1Azsp_sDMsNPT
    ///
    /// 5. Move the file Lib.cs to desktop and then try to debug.
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Lib l = new Lib();
            l.Func();
        }
    }
}
