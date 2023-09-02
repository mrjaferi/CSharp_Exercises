using System;

namespace DistanceConversion
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please enter your desired programming language :");
            Console.ResetColor();
            var language = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------\n");
            Console.ResetColor();

            switch (language)
            {
                case "c#":
                    Console.WriteLine("C# or C-Sharp is an object-oriented, data-driven (DOT .NET) programming language introduced by Microsoft Corporation in 2002. This language is used for the development of Windows, Web and mobile software and features such as graphic creation, image processing, building game programs, management programs, banking programs, web services, etc. It has it. Other features of this language include the ability to execute errors at compile time, newer features than C++ and being equipped with DOT .NET libraries.");
                    break;
                case "java":
                    Console.WriteLine("Java () is a programming language applicable to the development of open-source and widely covered software and applications. Java was originally offered by Sun Microsystems in 1995 and is currently being developed by Oracle Corporation.\n Java is used for various applications such as software development, web programming, Java applets, computer games, mobile applications, and many others. In addition to basic capabilities such as pointers, conditional expressions, iteration loops, and arrays, this programming language also provides facilities such as runtime error analysis and Unicode coding. Java is applicable on many operating systems, including Windows, Linux, and Macintosh, and is one of the most popular programming languages in the software industry due to its high stability and security.");
                    break;
                case "php":
                    Console.WriteLine("PHP or Hypertext Preprocessor is a server-side programming language used to develop websites. This programming language is available for free and is sponsored by a large community of programmers. PHP is provided in open source code format and can be easily accessed and edited.\n PHP is used to create dynamic web pages, forms, content management systems (CMS), online stores, and many other web applications. PHP is also one of the most widely used web programming languages with its upgradability and high usability.");
                    break;
                case "python":
                    Console.WriteLine("Python is a high-level, interpretive, object-oriented programming language used for software development, website, data processing, and artificial intelligence. This programming language was developed in 1991 by Guido van Rossum in the Netherlands, and its code has been published as open source.\n Python is very popular for reasons such as high readability, simplicity and intelligibility for new programmers, and wide application in a variety of industries, including data science, computer networking, website, and engineering sciences and life sciences. Python is in the category of interpreter programming languages, i.e., programs written with it are interpreted line-by-line, and in the category of dynamic languages, that is, it does not need to define the type of data before using them.");
                    break;
                case "javascript":
                    Console.WriteLine("JavaScript language is a programming language developed for the purpose of developing web applications. The language is commonly used in web browsers to implement programming code, and can be used to design dynamic web pages using various technologies such as HTML, CSS, and AJAX. JavaScript is a high-level language with several capabilities, including the ability to attempt to process user data and fetch information from web services and databases.");
                    break;
                case "swift":
                    Console.WriteLine("Swift is an object-oriented programming language developed by Apple Inc., used for the development of iOS, macOS, and watchOS applications. It was introduced in 2014, replacing the Objective-C language.\n The Swift language supports features such as simple and understandable syntax, high security, support for various data types, and deployed string and sentence functions. Also, Swift has tools such as advanced logwriting tools and dynamic tools for code analysis that developers use to better manage their code and deal with errors in it quickly.");
                    break;
                case "c":
                    Console.WriteLine("The C programming language, one of the most common programming languages, was coined in the 1970s by Dennis Ritchie at Bell Corporation for the development of the Unix operating system. C is a low-level (low-level) programming language and is known as the language used to write operating systems and drivers, as well as high-performance programs. Today, C is considered as one of the bases of programming languages in the software industry, and many security software, transportation systems, video and audio, computer games, etc. are written using this programming language.");
                    break;
                case "c++":
                    Console.WriteLine("C++ is an object-oriented, high-level, compiler programming language developed on the basis of the C language. C++ is actually considered as a powerful upgrade of the C language, and it has the ability to program complex systems. C++ has features such as inheritance, polymorphism, crowdsourcing, concurrency, and dynamic (dynamic). The language is used in many industrial sectors, including gamification, hardware software, application software, etc. As one of the most widely used programming languages, C++ is used by many large companies such as Microsoft, Google, Facebook, Amazon, and many other software companies.");
                    break;
                case "ruby":
                    Console.WriteLine("Ruby is an object-oriented and interpretive programming language created in Japan by Yukihiro Matsumoto in the 1990s. The language is used to build web software, command-line tools, video games, applications, and many other programming applications. Ruby is a dynamic and open language, with simple and understandable instructions. Among the main features of this language are heirability, polymorphism, Lambda-like blocks, transposable objects, insecure instructions, and crowdsourcing. Also, among the advantages of Ruby can be mentioned tools such as Rails, a web development framework for Ruby, which has made Ruby known as one of the popular programming languages in the software industry.");
                    break;
                case "html":
                    Console.WriteLine("HTML stands for HyperText Markup Language and means Hypertext Markup Language. HTML is one of the most popular markup languages for building web pages. Using HTML, it is possible to design web pages in a structured and understandable way by the web browser. In essence, HTML is a markup language used by websites to express the information structure, material, and content of web pages. In this language, labels are used to define different elements of pages such as text, images, links, tables, forms, etc. HTML writing follows W3C standards and is supported by all web browsers.");
                    break;
                case "css":
                    Console.WriteLine("CSS stands for Cascading Style Sheets and means Dynamic Style Sheets. CSS is a high-level language for describing how web pages are displayed, combined with HTML. Using CSS, the design and appearance of web pages from dimensions and colors to the order of placement of texts and images are determined with the help of specific CSS descriptors. The main purpose of CSS is to separate the configuration and appearance of web pages from their content structure. In this language, dynamic rules are specified for selecting HTML elements and determining their style. For example, it is possible to design the page background color, text font size, location of HTML elements, etc., by using CSS. Using CSS is very useful in designing dynamic and attractive websites.");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Error: Please write the name of a programming language.");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Please enter your desired programming language :");
                    Console.ResetColor();
                    var languageTry = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("----------------------------\n");
                    Console.ResetColor();

                    switch (languageTry)
                    {
                        case "c#":
                            Console.WriteLine("C# or C-Sharp is an object-oriented, data-driven (DOT .NET) programming language introduced by Microsoft Corporation in 2002. This language is used for the development of Windows, Web and mobile software and features such as graphic creation, image processing, building game programs, management programs, banking programs, web services, etc. It has it. Other features of this language include the ability to execute errors at compile time, newer features than C++ and being equipped with DOT .NET libraries.");
                            break;
                        case "java":
                            Console.WriteLine("Java () is a programming language applicable to the development of open-source and widely covered software and applications. Java was originally offered by Sun Microsystems in 1995 and is currently being developed by Oracle Corporation.\n Java is used for various applications such as software development, web programming, Java applets, computer games, mobile applications, and many others. In addition to basic capabilities such as pointers, conditional expressions, iteration loops, and arrays, this programming language also provides facilities such as runtime error analysis and Unicode coding. Java is applicable on many operating systems, including Windows, Linux, and Macintosh, and is one of the most popular programming languages in the software industry due to its high stability and security.");
                            break;
                        case "php":
                            Console.WriteLine("PHP or Hypertext Preprocessor is a server-side programming language used to develop websites. This programming language is available for free and is sponsored by a large community of programmers. PHP is provided in open source code format and can be easily accessed and edited.\n PHP is used to create dynamic web pages, forms, content management systems (CMS), online stores, and many other web applications. PHP is also one of the most widely used web programming languages with its upgradability and high usability.");
                            break;
                        case "python":
                            Console.WriteLine("Python is a high-level, interpretive, object-oriented programming language used for software development, website, data processing, and artificial intelligence. This programming language was developed in 1991 by Guido van Rossum in the Netherlands, and its code has been published as open source.\n Python is very popular for reasons such as high readability, simplicity and intelligibility for new programmers, and wide application in a variety of industries, including data science, computer networking, website, and engineering sciences and life sciences. Python is in the category of interpreter programming languages, i.e., programs written with it are interpreted line-by-line, and in the category of dynamic languages, that is, it does not need to define the type of data before using them.");
                            break;
                        case "javascript":
                            Console.WriteLine("JavaScript language is a programming language developed for the purpose of developing web applications. The language is commonly used in web browsers to implement programming code, and can be used to design dynamic web pages using various technologies such as HTML, CSS, and AJAX. JavaScript is a high-level language with several capabilities, including the ability to attempt to process user data and fetch information from web services and databases.");
                            break;
                        case "swift":
                            Console.WriteLine("Swift is an object-oriented programming language developed by Apple Inc., used for the development of iOS, macOS, and watchOS applications. It was introduced in 2014, replacing the Objective-C language.\n The Swift language supports features such as simple and understandable syntax, high security, support for various data types, and deployed string and sentence functions. Also, Swift has tools such as advanced logwriting tools and dynamic tools for code analysis that developers use to better manage their code and deal with errors in it quickly.");
                            break;
                        case "c":
                            Console.WriteLine("The C programming language, one of the most common programming languages, was coined in the 1970s by Dennis Ritchie at Bell Corporation for the development of the Unix operating system. C is a low-level (low-level) programming language and is known as the language used to write operating systems and drivers, as well as high-performance programs. Today, C is considered as one of the bases of programming languages in the software industry, and many security software, transportation systems, video and audio, computer games, etc. are written using this programming language.");
                            break;
                        case "c++":
                            Console.WriteLine("C++ is an object-oriented, high-level, compiler programming language developed on the basis of the C language. C++ is actually considered as a powerful upgrade of the C language, and it has the ability to program complex systems. C++ has features such as inheritance, polymorphism, crowdsourcing, concurrency, and dynamic (dynamic). The language is used in many industrial sectors, including gamification, hardware software, application software, etc. As one of the most widely used programming languages, C++ is used by many large companies such as Microsoft, Google, Facebook, Amazon, and many other software companies.");
                            break;
                        case "ruby":
                            Console.WriteLine("Ruby is an object-oriented and interpretive programming language created in Japan by Yukihiro Matsumoto in the 1990s. The language is used to build web software, command-line tools, video games, applications, and many other programming applications. Ruby is a dynamic and open language, with simple and understandable instructions. Among the main features of this language are heirability, polymorphism, Lambda-like blocks, transposable objects, insecure instructions, and crowdsourcing. Also, among the advantages of Ruby can be mentioned tools such as Rails, a web development framework for Ruby, which has made Ruby known as one of the popular programming languages in the software industry.");
                            break;
                        case "html":
                            Console.WriteLine("HTML stands for HyperText Markup Language and means Hypertext Markup Language. HTML is one of the most popular markup languages for building web pages. Using HTML, it is possible to design web pages in a structured and understandable way by the web browser. In essence, HTML is a markup language used by websites to express the information structure, material, and content of web pages. In this language, labels are used to define different elements of pages such as text, images, links, tables, forms, etc. HTML writing follows W3C standards and is supported by all web browsers.");
                            break;
                        case "css":
                            Console.WriteLine("CSS stands for Cascading Style Sheets and means Dynamic Style Sheets. CSS is a high-level language for describing how web pages are displayed, combined with HTML. Using CSS, the design and appearance of web pages from dimensions and colors to the order of placement of texts and images are determined with the help of specific CSS descriptors. The main purpose of CSS is to separate the configuration and appearance of web pages from their content structure. In this language, dynamic rules are specified for selecting HTML elements and determining their style. For example, it is possible to design the page background color, text font size, location of HTML elements, etc., by using CSS. Using CSS is very useful in designing dynamic and attractive websites.");
                            break;
                    }
                    break;

            }
        }
    }
}