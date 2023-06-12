// Copyright (c) 2023  Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;
using System.Runtime.Serialization;

namespace Fundamentals.Lesson7
{
    internal static partial class TryCatch
    {
        public static void WriteToFile()
        {
            try
            {
                // Create an instance of the object to serialize
                Person person = new Person(30, "John Doe");
                //Person person = new Person(30, null);

                // Create a DataContractSerializer
                DataContractSerializer serializer = new DataContractSerializer(typeof(Person));

                var pathToSave = "C:\\Users\\elton.cassas\\Projects\\Training\\person.xml";
                // var pathToSave = "C:\\Users\\eltoncassas\\Training\\person.xml";

                // Serialize the object to a file
                using (FileStream fileStream = new FileStream(pathToSave, FileMode.Create))
                {
                    serializer.WriteObject(fileStream, person);
                }

                Console.WriteLine("Serialization completed successfully.");
            }
            catch (InvalidDataContractException ex)
            {
                Console.WriteLine("An error occurred during serialization.Data Contract attribute seems to be missing");
                Console.WriteLine($"Exception details: {ex.Message}");
                ex.StackTrace.Dump();
            }
            catch (ArgumentNullException e)
            {
                throw;
                //throw new ArgumentNullException(e.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                //throw new PathNotFoundException(ex.Message);
                //throw new PathNotFoundException(ex.Message, ex.InnerException);
                throw new PathNotFoundException(ex.Message, ex); // rethrow or log correctly the inner exception
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during serialization.");
                Console.WriteLine($"Exception details: {ex.Message}");
                ex.StackTrace.Dump();
            }
            finally
            {
                Console.WriteLine("Closing the app now...");
            }
        }
    }
}
