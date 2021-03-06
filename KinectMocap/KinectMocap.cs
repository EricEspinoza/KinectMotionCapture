﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KinectMocap
{
    class KinectMocap
    {
        private SkeletalTracker skeletalTracker;

        public KinectMocap() {
            skeletalTracker = new SkeletalTracker();
        }

        public void Init() {
            skeletalTracker.Init();
            Console.Title = "Kinect Debug";
        }

        public bool Update() {
            skeletalTracker.Update();
            Console.Clear();
            skeletalTracker.Debug();
            return true;
        }

        public void BVH(ref string output) {
            skeletalTracker.CreateBVH();
        }
    }
}
