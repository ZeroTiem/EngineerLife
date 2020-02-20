using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    public class No1282_Group_the_People_Given_the_Group_Size_They_Belong_To
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<Group> groups = new List<Group>();

            for (int i = 0; i < groupSizes.Length; i++)
            {
                var size =  groupSizes[i];

                var group = groups.FirstOrDefault(x => x.GroupLength == size && x.Values.Count != size);

                if (group == null)
                {
                    groups.Add(
                        new Group
                        {
                            GroupLength = size,
                            Values = new List<int> { i }
                        });
                }
                else
                {
                    group.Values.Add(i);
                }
            }
           
            return groups.Select(x => x.Values).ToList();
        }

        public class Group
        {
            public int GroupLength { get; set; }
            public IList<int> Values { get; set; }
        }


    }
}
