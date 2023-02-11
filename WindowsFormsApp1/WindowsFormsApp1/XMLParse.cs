using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1 {
    internal class XMLParse {
        public static string fileXML;
        public struct ProductData {
            // Низ
            public string ki,
                cis,
                product_date,
                certificate_type;
            public int tnved_code;
        };

        public struct ProductData2 {
            // Верх
            public string product_date1,
                batch,
                line,
                startmarking,
                stopmarking,
                produced,
                read,
                record,
                rejected,
                production_order;
            public List<ProductData> products;
        };

        public ProductData2 XMLParse_Doc() {
            XmlDocument docXML = new XmlDocument(); // XML-документ
            docXML.LoadXml(fileXML); // загрузить XML
            XmlElement xmlElement = docXML.DocumentElement;
            ProductData2 productData2 = new ProductData2();
            productData2.products = new List<ProductData>();
            productData2.products.Clear();
            ProductData productData = new ProductData();

            foreach (XmlNode node in xmlElement.ChildNodes) {
                if (node.Name == "product_date") productData2.product_date1 = node.InnerText;
                if (node.Name == "batch") productData2.batch = node.InnerText;
                if (node.Name == "line") productData2.line = node.InnerText;
                if (node.Name == "startmarking") productData2.startmarking = node.InnerText;
                if (node.Name == "stopmarking") productData2.stopmarking = node.InnerText;
                if (node.Name == "produced") productData2.produced = node.InnerText;
                if (node.Name == "read") productData2.read = node.InnerText;
                if (node.Name == "record") productData2.record = node.InnerText;
                if (node.Name == "rejected") productData2.rejected = node.InnerText;
                if (node.Name == "production_order") productData2.production_order = node.InnerText;
                if (node.Name == "products_list") {
                    foreach (XmlNode node2 in node.ChildNodes) {
                        if (node2.Name == "product") {
                            foreach (XmlNode node3 in node2.ChildNodes) {
                                if (node3.Name == "ki") {
                                    productData.ki = node3.InnerText;
                                }
                                if (node3.Name == "cis") {
                                    productData.cis = node3.InnerText;
                                }
                                if (node3.Name == "product_date") {
                                    productData.product_date = node3.InnerText;
                                }
                                if (node3.Name == "tnved_code") {
                                    productData.tnved_code = Convert.ToInt32(node3.InnerText);
                                }
                                if (node3.Name == "certificate_type") {
                                    productData.certificate_type = node3.InnerText;
                                }
                            }
                            productData2.products.Add(productData);
                        }
                    }
                }
            }
            productData2.products.Add(productData);
            return productData2;
        }
    }
}
