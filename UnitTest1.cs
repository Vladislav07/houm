using Microsoft.VisualStudio.TestTools.UnitTesting;
using New.Domain.Entities;
using New.Web.Controllers;
using New.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Net.Test
{
    [TestClass]
    public class UnitTestCart
    {
        
       [TestMethod]
        public void Test_Raskroy()
        {
          //Arrange
            NestingController NesKontr = new NestingController();

           //Act
           data_order result = (data_order)NesKontr.Index().Model;

          //Assert
          //  List<Material> mat = result.Materials.ToList();
         //  List<part> p=result.Parts.ToList();
         //  List<nesting_plan> n_p = result.NestingPlans.ToList();
         //  List<part_nesting> raskroy = result.PartNestings.ToList();

           Assert.AreEqual(result.materials.Count(), 1);
          //  Assert.AreEqual(p.Count, 1);
          // Assert.AreEqual(p[0].width, 35);
          //  Assert.AreEqual(raskroy[0].x, 0);
          //  Assert.AreEqual(raskroy[0].y, 0);

           
        }

       [TestMethod]
       public void Test_Raskroy1()
       {
           //Arrang
           XDocument xd=XDocument.Load(@"D:\Мои документы\AstraOut.xml");
        
           //Act
           EcsportXML ecsport = new EcsportXML();
           ecsport.D(xd);
         
           //Assert
           Material m=ecsport.order.list_materials[0];
           nesting_plan np = m.list_nesting_plans[0];
           Assert.AreEqual(ecsport.order.name, "new11");
           Assert.AreEqual(ecsport.order.list_materials[0].index, 4);
           Assert.AreEqual(ecsport.order.list_materials[0].name, "г/к");
           Assert.AreEqual(m.type, "");
           Assert.AreEqual(m.list_parts[0].width, 35);
           Assert.AreEqual(m.list_parts[0].Length, 250);
           Assert.AreEqual(m.list_nesting_plans[0].length, 6000);
           Assert.AreEqual(m.list_nesting_plans.Count, 1);
          Assert.AreEqual(m.list_nesting_plans[0].width, 1500);
          Assert.AreEqual(np.list_parts_nesting[0].x,0);
          Assert.AreEqual(np.list_parts_nesting[0].y, 0);
          Assert.AreEqual(np.list_parts_nesting[1].y, 35);
          Assert.AreEqual(np.list_parts_nesting[0].number, 0);
       }
    


    }
}
