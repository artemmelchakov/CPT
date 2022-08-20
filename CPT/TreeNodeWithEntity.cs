using CPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT
{
    public class TreeNodeWithEntity: TreeNode
    {
        public IEntity entity;
        public TreeNodeWithEntity(string text, IEntity entity): base(text)
        {
            this.entity = entity;
        }
    }
}
