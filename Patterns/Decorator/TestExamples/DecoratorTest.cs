using Patterns.Decorator.Classes;
using Patterns.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.TestExamples
{
    class DecoratorTest : IPatternTest
    {
        public void Run()
        {
            //That's an example of Stream decorators
            using (var fileStream = new FileStream("file.gz", FileMode.Create))
            using (var zipStream = new GZipStream(fileStream, CompressionLevel.Optimal))
            {
                zipStream.Write(Encoding.UTF8.GetBytes("olololololo"), 0, "olololololo".Length);
            }

            //And that' my stuff
            IGirl standardKitGirl = new AttractiveGirlDecorator(new BasicGirl());

            IGirl extendedKitGirl = new AttractiveGirlDecorator(
                                        new NiceAssGirlDecorator(
                                            new SharpDressedGirlDecorator(
                                                new BasicGirl())));

            IGirl megaGirl = new AttractiveGirlDecorator(
                                    new NiceAssGirlDecorator(
                                        new SharpDressedGirlDecorator(
                                            new IntelligentGirlDecorator(
                                                new JazzGirlDecorator(
                                                    new BasicGirl())))));

            foreach (var girl in new[] { standardKitGirl, extendedKitGirl, megaGirl })
            {
                girl.Talk();
                Console.WriteLine();
            }

            //Output:

            //I am just a girl
            //I am attractive

            //I am just a girl
            //Every man is crazy 'bout sharp dressed me
            //I'm hot and got a nice ass!
            //I am attractive

            //I am just a girl
            //I do love jazz
            //I'm able to speak an intelligent way
            //Every man is crazy 'bout sharp dressed me
            //I'm hot and got a nice ass!
            //I am attractive                  
        }
    }
}
