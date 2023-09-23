using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.DayThree
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        public override string ToString()
        {
            Console.WriteLine("Media Tostring");
            return "AudioContent";
        }
    }
    internal class AudioContent : MediaContent
    {
        public sealed override void StartPlayingContent()
        {
            Console.WriteLine("start from AudioContent");
        }
    }
    internal class VideoContent : AudioContent
    {
        
    }

    internal class MediaTester
    {
        public static void TestOne()
        {

        }
    }
}
