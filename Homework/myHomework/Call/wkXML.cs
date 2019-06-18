using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace myHomework.Call
{
    public static class wkXML
    {
        public static void CreateXML()
        {
            //1,生成xml对象
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "myXML.xml");
            XElement element = new XElement(
                "articles",
                new XComment("以下存放所有\"源栈\"所有文章"),/*注释*/
                new XElement(
                    "article", new XAttribute("isDraft", false),/*根下子节点*/
                  new XElement("id", 1),
                  new XElement("title", "源栈培训:C#进阶-7:Linq to XML"),
                  new XElement("body", "什么是XML(Extensible Markup Language)是一种文本文件格式被设计用来传输和存储数据由：标签和属性组成元素（节点），由元素组成“树状结构”必须有而且只能有一个根节点其他："),
                  new XElement("authorId", 1),
                  new XElement("publishDate", "2019/6/18 18:15"),
                  new XElement("comments",
                   new XElement("comment", new XAttribute("recommend", true),
                     new XElement("id", 12),
                     new XElement("body", "不错,赞!"),
                     new XElement("authorId", 2)
                    ),
                   new XElement("comment", new XAttribute("recommend", true),
                     new XElement("id", 14),
                     new XElement("body", "作业太难了"),
                     new XElement("authorId", 3)
                     )
                   )/*comments元素*/
                 ),/*根下子节点article*/
                new XElement("article", new XAttribute("isDraft", true),
                  new XElement("id", 2),
                  new XElement("title", "源栈培训:C#进阶-6:异步和并行"),
                  new XElement("authorId", 1)
                )/*article兄弟元素*/
                );/*根节点*/

            XDocument document = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"), element);
            Console.WriteLine(element);
            //document.Save(path);

            //3,从磁盘读取
            XElement fromDisk = XElement.Load(path);
            //Console.WriteLine(fromDisk);

            //4,根节点添加article元素
            fromDisk.Add(
                new XElement("article",
                 new XElement("id", 15),
                 new XElement("title", "多线程完结"),
                 new XElement("authorId", 6)
                 ));
            Console.WriteLine(fromDisk);

            Console.WriteLine();
            //5,删除id=12评论
            
        }
    }
}
