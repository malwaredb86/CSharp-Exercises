
string sentence = "Alice was beginning to get very tired of sitting by her sister on the\nbank, and of having nothing to do: once or twice she had peeped into the\nbook her sister was reading, but it had no pictures or conversations in\nit, 'and what is the use of a book,' thought Alice 'without pictures or\nconversation?'";
Console.WriteLine(sentence);
string sentenceSearch = sentence.ToLower();
Console.Write("Enter your search term: ");
string searchTerm = Console.ReadLine();
string search = searchTerm.ToLower();

if (sentenceSearch.Contains(search))
{
    Console.WriteLine("The search term is at index " + sentenceSearch.IndexOf(search) + " and is " + search.Length + " characters long.");
    string[] newSentence = sentenceSearch.Split(search);
    Console.WriteLine(newSentence[0] + newSentence[1]);
}
else Console.WriteLine("false");
