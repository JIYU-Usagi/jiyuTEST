using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.Attributes;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Structure;
using Autodesk.Revit.UI.Selection;
using System.Data;



namespace Modless
{
    internal class Util
    {

        //유형 이름으로 floortype을 찾아주는 함수 
        public static FloorType FindFloorTypeByName(Document doc, string name)
        {
            FloorType ft = null;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfClass(typeof(FloorType));

            foreach (FloorType floortype in col)
            {
                if (floortype.Name == name)
                {
                    ft = floortype;
                    break;
                }

            }
            return ft;

        }


        //커브루프 리스트를 받아서 바닥을 생성하는 함수
        public static void CreateFloor(Document doc, IList<CurveLoop> cl, ElementId floorid, ElementId levelid, double t)
        {
            using (Transaction trans = new Transaction(doc, "바닥을 생성합니다"))
            {
                trans.Start();
                Floor f = Floor.Create(doc, cl, floorid, levelid);
                //바닥 두께만큼 높이를 올려서 바닥을 생성한다
                Parameter heightparam = f.get_Parameter(BuiltInParameter.FLOOR_HEIGHTABOVELEVEL_PARAM);
                heightparam.Set(t);
                trans.Commit();
            }
        }

        //타입이름으로 벽 타입 찾는 함수
        public static WallType GetWallRtpeByName(Document doc, string name)
        {
            WallType wt = null;
            FilteredElementCollector col = new FilteredElementCollector(doc);
            col.OfCategory(BuiltInCategory.OST_Walls);
            col.OfClass(typeof(WallType));

            foreach ( WallType item in col)
            {
                if (name == item.Name)
                {
                    wt = item;
                    break;
                }
            }
            return wt;
        }

        //벽 타입으로 벽두께 찾는 함수

        public static double GetWallTHK (WallType wt)
        {
            Parameter param = wt.get_Parameter(BuiltInParameter.WALL_ATTR_WIDTH_PARAM);
            double t = param.AsDouble();

            return t;
        }

        //벽 생성 함수

        public static void CreateWall (Document doc, Curve c, WallType wt, Level level, double t, bool isSTR)
        {
            //레빗파일에서 생성하는 것이므로 트랙젠션 사용
            using (Transaction trans = new Transaction(doc, "마감벽을 그립니당"))
            {
                trans.Start();
                Wall wall = Wall.Create(doc, c, wt.Id, level.Id, t/304.8, 0, false, isSTR);
                trans.Commit();
            }
        }
    }
}
