using System;

namespace Bookstore_HHs
{
    class Program
    {
        static public void AddBook(ref string name, ref string num, ref string price, ref string genre)
        {
            Console.WriteLine("책의 이름을 입력해주세요. ");
            name = Console.ReadLine();
            Console.WriteLine();
         
            Console.WriteLine("책의 번호을 입력해주세요. ");
            num = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("책의 가격을 입력해주세요. ");
            price = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("책의 장르를 입력해주세요. ");
            Console.WriteLine("Novel : [ N ], Comic : [ C ]");
            genre = Console.ReadLine();
            Console.WriteLine();

            return;
        }
        
        static public void Search(string keyword, Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    continue;
                }

                if(keyword == books[i].name)
                {
                    BookInfo(books,i);
                    continue;
                }

                if (keyword == books[i].number)
                {
                    BookInfo(books, i);
                    continue;
                }

                if (keyword == books[i].price)
                {
                    BookInfo(books, i);
                    continue;
                }
            }
            
            return;
        }

        static public void SearchtoNumber(string keyword, Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    continue;
                }

                if (keyword == books[i].number)
                {
                    BookInfo(books, i);
                }
            }

            return;
        }

        static public void SearchtoName(string keyword, Book[] books)
        {
            int count = 0;
            string[] arrBooks = books[count].name.Split();
            string[] arrKeyword = keyword.Split();

            for (int i = 0; i < arrBooks.Length; i++)
            {
                for (int j = 0; j < arrKeyword.Length; j++)
                {
                    if (arrKeyword[j] == arrBooks[i])
                    {
                        BookInfo(books, i);
                    }
                }
                count++;
            }

            return;
        }
        static public void ComicArr(ref Book[] books, ref Book[] comicBooks)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i] == null)
                {
                    continue;
                }
                if (books[i].genre != "Comic")
                {
                    continue;
                } 
                else
                {
                    comicBooks[i] = books[i];
                } 
            }
            return;
        }
        static public void NovelArr(ref Book[] books, ref Book[] novelBooks)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    continue;
                }
                if (books[i].genre != "Novel")
                {
                    continue;
                }
                else
                {
                    novelBooks[i] = books[i];
                }
            }
            return;
        }

        static public void Delete(Book[] books)
        {
            Console.WriteLine("삭제하려는 책을 입력하세요.");
            string numNum = Console.ReadLine();
            int num = int.Parse(numNum);

            BookInfo(books, ref num, numNum);

            Console.WriteLine("삭제하시겠습니까? [Y / N]");
            string key = Console.ReadLine();

            if (key == "y" || key == "Y")
            if (key.ToUpper() == "Y")
            {
                books[num].name = null; 
                books[num].number = null; 
                books[num].price = null;
                books[num].genre = null;
                books[num] = null;
                Console.WriteLine("성공적으로 삭제되었습니다.");
                return;
            }

            if (key == "n" || key == "N") return;
        }

        static public void BookInfo(Book[] books, int num)
        {
            if (books[num] != null)
            {
                Console.Write($"책 번호 : {books[num].number}번, 책명 :{books[num].name}, 책 가격 : {books[num].price}원, 장르 : {books[num].genre}");
                Console.WriteLine();
            }

            return;
        }

        static public void BookInfo(Book[] books, ref int num, string number)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null) continue;
                if(number == books[i].number)
                {
                    num = i;
                    Console.Write($"책 번호 : {books[num].number}번, 책명 :{books[num].name}, 책 가격 : {books[num].price}원, 장르 : {books[num].genre}");
                    Console.WriteLine();
                    return;
                }
            }

            return;
        }

        static public void AllPrise(Book[] books)
        {
            int priseNum = 0;
            int prise = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if(books[i] != null)
                {
                    priseNum = int.Parse(books[i].price);
                    prise += priseNum;
                }
            }
            Console.WriteLine($"전채 재고의 가격은 {prise}원 입니다.");
        }

        static public void Refresh()
        {
            Console.WriteLine("\n아무 키를 눌러 나가십시오.");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        static void Main(string[] args)
        {
            Book[] books = new Book[100];
            Book[] comicBooks = new Book[100];
            Book[] novelBooks = new Book[100];
            string[] bookName = new string[100];
            string[] bookNum = new string[100];
            string[] bookPrice = new string[100];
            string[] bookGenre = new string[100];

            string nametmp ;
            string numtmp ;
            string pricetmp;
            string genretmp;
            int count = 0;

            while (true)
            {
                string key;

                Console.WriteLine("******** BOOK STORE PROGRAM ********\n");
                Console.WriteLine("이용하려는 기능을 입력하세요.\n");
                Console.WriteLine("* 책 추가 [ADD or A]\n* 책 검색 [SEARCH or S]\n* 책 삭제 [DELETE or D]");
                Console.WriteLine("* 책 정보 전체 보기 [ALL]\n* 전체 재고 가격보기 [prise or p]\n* 테스트북 추가 [add booktest]\n* 종료 [X]\n");
                Console.Write("> ");

                key = Console.ReadLine();
                Console.WriteLine();

                if (key == "ADD" || key == "add" || key == "a" || key == "A")
                {
                    AddBook(ref bookName[count], ref bookNum[count], ref bookPrice[count],ref bookGenre[count]);
                    
                    nametmp = bookName[count];
                    numtmp = bookNum[count];
                    pricetmp = bookPrice[count];
                    genretmp = bookGenre[count];
                    if (genretmp == "n" || genretmp == "N") genretmp = "Novel";
                    if (genretmp == "c" || genretmp == "C") genretmp = "Comic";
                    books[count] = new Book(nametmp, numtmp, pricetmp, genretmp);

                    BookInfo(books, count);

                    key = null;
                    count++;

                    Refresh();
                }

                if (key == "SEARCH" || key == "search" || key == "S" || key == "s")
                {
                    Console.WriteLine("전체 검색 [A], 번호로 검색 [B], 이름으로 검색 [C]");
                    Console.WriteLine("Comic [Comic], Novel (Novel)");
                    key = Console.ReadLine();
                    Console.WriteLine();

                    if(key == "A" || key == "a")
                    {
                        Console.WriteLine("검색하시려는 단어를 입력하세요. ");
                        string keyword = Console.ReadLine();
                        Search(keyword, books);
                    }

                    if (key == "B" || key == "b")
                    {
                        Console.WriteLine("검색하시려는 번호를 입력하세요. ");
                        string keyword = Console.ReadLine();
                        SearchtoNumber(keyword, books);
                    }

                    if (key == "C" || key == "c")
                    {
                        Console.WriteLine("검색하시려는 책명를 입력하세요. ");
                        string keyword = Console.ReadLine();
                        SearchtoName(keyword, books);
                    }

                    if(key == "comic" || key == "co")
                    {
                        ComicArr(ref books, ref comicBooks);
                        Console.WriteLine("Comic 책 검색 [A]\nComic 책 전체 보기[B]");
                        key = Console.ReadLine();
                        if(key == "A" || key == "a")
                        {
                            Console.WriteLine("검색하시려는 단어를 입력하세요. ");
                            Console.WriteLine();
                            string keyword = Console.ReadLine();
                            Search(keyword, comicBooks);
                        }
                        if (key == "B" || key == "b")
                        {
                            for (int i = 0; i < comicBooks.Length; i++)
                            {
                                BookInfo(comicBooks, i);
                            }
                        }
                    }

                    if(key == "novel" || key == "n")
                    {
                        NovelArr(ref books, ref novelBooks);
                        Console.WriteLine("Novel 책 검색 [A]\nNovel 책 전체 보기[B]");
                        key = Console.ReadLine();

                        if (key == "A" || key == "a")
                        {
                            Console.WriteLine("검색하시려는 단어를 입력하세요. ");
                            Console.WriteLine();
                            string keyword = Console.ReadLine();
                            Search(keyword, novelBooks);
                        }

                        if (key == "B" || key == "b")
                        {
                            for (int i = 0; i < novelBooks.Length; i++)
                            {
                                BookInfo(novelBooks, i);
                            }
                        }
                    }

                    Refresh();
                }

                if (key == "DELETE" || key == "delete" || key == "D" || key == "d")
                {
                    Delete(books);
                    Refresh();
                }

                if (key == "ALL" || key == "all")
                {
                    for (int i = 0; i < bookName.Length; i++)
                    {
                        BookInfo(books, i);
                    }
                    Refresh();
                }

                if(key == "prise" || key == "p")
                {
                    AllPrise(books);
                    Refresh();
                }

                if (key == "X" || key == "x")
                {
                    Console.WriteLine("프로그램이 종료되었습니다.");
                    break;
                }

                if (key == "add booktest")
                {
                    BookTest comicBook = new BookTest("만화책", "200", "3000", "Comic");
                    BookTest comicBook2 = new BookTest("만화책2", "201", "4000", "Comic");
                    BookTest novelBook = new BookTest("소설책", "300", "10000", "Novel");
                    BookTest novelBook2 = new BookTest("소설책2", "301", "20000", "Novel");

                    books[count] = comicBook;
                    books[count + 1] = comicBook2;
                    books[count + 2] = novelBook;
                    books[count + 3] = novelBook2;

                    count += 4;

                    Console.WriteLine("성공적으로 추가되었습니다.");
                    Refresh();
                }

                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
