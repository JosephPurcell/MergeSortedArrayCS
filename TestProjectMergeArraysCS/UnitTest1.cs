namespace TestProjectMergeArraysCS
{
    using MergeSortedArrayCS;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;
            int[] expected = [1, 2, 2, 3, 5, 6];

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            for (int i = 0; i < m + n; i++)
            {
                if (nums1[i] != expected[i])
                {
                    Assert.Fail();
                }
            }
        }


        [TestMethod]
        public void TestMethod2()
        {
            int[] nums1 = [1];
            int m = 1;
            int[] nums2 = [];
            int n = 0;
            int[] expected = [1];

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            for (int i = 0; i < m + n; i++)
            {
                if (nums1[i] != expected[i])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums1 = [0,0];
            int m = 0;
            int[] nums2 = [1,2];
            int n = 2;
            int[] expected = [1,2];

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            for (int i = 0; i < m + n; i++)
            {
                if (nums1[i] != expected[i])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums1 = [1, 3, 5, 8, 0,0,0,0];
            int m = 4;
            int[] nums2 = [2,4,6,7];
            int n = 4;
            int[] expected = [1, 2, 3,4,5,6,7,8];

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            for (int i = 0; i < m + n; i++)
            {
                if (nums1[i] != expected[i])
                {
                    Assert.Fail();
                }
            }
        }

    }
}