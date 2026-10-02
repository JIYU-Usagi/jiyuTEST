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
using System.CodeDom;

namespace Modless
{
    internal class FloorATT
    {
        public static List<floor> GetFloorData(Document doc, UIDocument uiDoc, string name)
        {
            List<floor> floors = new List<floor>();

            IList<Reference> refs = uiDoc.Selection.PickObjects(ObjectType.Face, "구조바닥을 선택하세용");

            //Floor levelFloor = null;

            Element e1 = doc.GetElement(refs[0]);
            Floor levelFloor = e1 as Floor;
            Parameter levelparam = levelFloor.get_Parameter(BuiltInParameter.LEVEL_PARAM);
            ElementId level = levelparam.AsElementId();

            //레빗 파일에서 참조한 바닥의 모서리를 선택해서 정보를 저장해놓는다
            //여러 면을 선택할 수 있으므로 IList로 작성한다.
            //각 면의 경계선을 커브루프로 가져온다(슬라브가 뚫려있을수있으므로 edgearrayarray로 받는다
            foreach (Reference item in refs)
            {
                //선택한 면의 경계 선택
                floor f = new floor();
                f.m_Level = level;
                Element e = doc.GetElement(item);
                levelFloor = e as Floor;
                Face face = e.GetGeometryObjectFromReference(item) as Face;
                EdgeArrayArray eaa = face.EdgeLoops;

                //각 경계를 이루는 선들을 커브루프로 만들어서 cl에 넣어준다
                //edgearrayarray이므로 foreach를 두 번 사용해준다
                IList<CurveLoop> cls = new List<CurveLoop>();
                foreach (EdgeArray ea in eaa)
                {
                    CurveLoop cl = new CurveLoop();
                    foreach (Edge ed in ea)
                    {
                        Curve c = ed.AsCurveFollowingFace(face);
                        cl.Append(c);
                    }

                    //최종 구한 엣지들을 cl에 넣고 cls에 넣어준다
                    cls.Add(cl);
                }

                //해당 이름의 유형이나 두께가 없을 시 경고창을 띄운다
                //Util에서 작성한 함수 불러서 쓰기
                //유형찾기
                f.m_LCurveLopps = cls;
                FloorType ft = Util.FindFloorTypeByName(doc, name);
                if (ft==null)
                {
                    TaskDialog.Show("경고", "바닥유형없슴");
                }

                f.m_FloorType = ft.Id;

                //두께찾기
                Parameter param = ft.get_Parameter(BuiltInParameter.FLOOR_ATTR_DEFAULT_THICKNESS_PARAM);
                if (param == null)
                {
                    TaskDialog.Show("경고", "두께값없슴");
                }

                double t = param.AsDouble();
                f.m_FloorTypeTHK = t;

                floors.Add(f);
            }
            return floors;
        }
    }

    //전역변수 설정
    //커브로부터 찾은 정보들을 floor에 담아서 리스트로 만들어서 필요할 떄 꺼내쓴다
    public class floor
    {
        public ElementId m_Level {  get; set; }
        public ElementId m_FloorType { get; set; }

        public IList<CurveLoop> m_LCurveLopps { get; set; }

        public double m_FloorTypeTHK { get; set; }

    }

}
