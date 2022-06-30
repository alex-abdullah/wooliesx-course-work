using System;
namespace pangpang
{
    public class CrapClass
    {
        public CrapClass()
        {
        }

        public CrapClass(int x)
        {
        }

        public CrapClass(string y)
        {
        }

        public CrapClass(double z)
        {
        }

        //Constructors and the static methods aren't related

        public static int someStaticUselessThing(int param)
        {
            return param + 3;
        }
    }
}

/*
 * 
 * private class FacialRecognition 
 * {
 *    // A bunch of complex data related to like machine learning of faces
 *    private int faceWidth;
 *    private int eyePupilDetectionThing;
 *    ... 100s of complex private data
 *    
 *    public bool IsMatch(Face face) {
 *     //...
 *    }
 * }
 * 
 * public class Shopper
 * {
 *  string name;
 *  int age;
 *  
 *  //
 *  if(IsMatch(myface)) {
 *   //call the cops
 *  }
 *  
 * }
 * 
 * 
 * 
 */