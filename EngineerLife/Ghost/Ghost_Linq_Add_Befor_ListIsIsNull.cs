using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineerLife.Ghost
{
    //https://stackoverflow.com/questions/48263237/ienumerable-and-lazy-loading
    //As said above, deferred execution != lazy loading.

    public class Ghost_Linq_Add_Befor_ListIsIsNull
    {
        public IEnumerable<(int key, int index)> AddList()
        {
            var reuslt = new List<int>();
            var list = new List<(int key, int index)>
            {
                (key: 1, index: 1),
                (key: 2, index: 1),
                (key: 3, index: 1),
                (key: 4, index: 1),
                (key: 5, index: 1),
                (key: 6, index: 1),
                (key: 7, index: 1),
                (key: 8, index: 1),
                (key: 9, index: 1)
            };
            var selectList = list.Where(x => reuslt.Contains(x.key) == false);
            reuslt.AddRange(selectList.Select(x => x.key));
            return selectList;
        }

        public IEnumerable<int> AddListMode1()
        {
            var reuslt = new List<int>();
            var list = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            var selectList = list.Where(x => x < 10);
            for (var i = 0; i < list.Count; i++)
            {
                list[i] = list[i] + 10;
            }

            list.ForEach(x => x = 10 + x);

            foreach (int i in list)
            {
                //i = i + 10;
            }

            return selectList;
        }

        //public IEnumerable<(int key, int index)> AddListMode1()
        //{
        //    var reuslt = new List<int>();
        //    var list = new List<(int key, int index)>
        //    {
        //        (key: 1, index: 1),
        //        (key: 2, index: 1),
        //        (key: 3, index: 1),
        //        (key: 4, index: 1),
        //        (key: 5, index: 1),
        //        (key: 6, index: 1),
        //        (key: 7, index: 1),
        //        (key: 8, index: 1),
        //        (key: 9, index: 1)
        //    };
        //    var selectList = list.Where(x => x.index == 1);
        //    for (var i = 0; i < list.Count; i++)
        //    {
        //        //list[i].index = 10;
        //        var item = list[i];
        //        item.index++;
        //        list[i] = item;
        //    }
        //    var print = selectList.ToList();
        //    return selectList;
        //}
    }
}
