using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NovaSkillTree
{
    public class SkillTree : MonoBehaviour
    {
        SkillNode Root = null;
        int ID_Assignment = 0;

        //---------------------------------------------------------------------------------------------------

        //checks to see if the list is empty by checking if the Root of the Tree is null
        bool IsEmpty()
        {
            return (Root == null);
        }

        //---------------------------------------------------------------------------------------------------

        //removes a Skill from Skill Tree by the ID of the skill
        public SkillNode RemoveNode(SkillNode root, int ID)
        {
            if (IsEmpty())
            {
                Debug.Log("[REMOVE] - List is Empty, cannot remove from empty Tree");
                return root;
            }

            if (ID < root.Skill_ID)
            {
                root.left = RemoveNode(root.left, ID);
            }
            else if (ID > root.Skill_ID)
            {
                root.right = RemoveNode(root.right, ID);
            }
            else
            {
                if (root.left == null)
                {
                    return root.right;
                }
                else if (root.right == null)
                {
                    return root.left;
                }

                root.Skill_ID = OrderSuccessor(root.right);
                root.right = RemoveNode(root.right, root.Skill_ID);
            }

            return root;

        }

        //---------------------------------------------------------------------------------------------------

        int OrderSuccessor(SkillNode root)
        {
            int minimum = root.Skill_ID;
            while (root.left != null)
            {
                minimum = root.left.Skill_ID;
                root = root.left;
            }
            return minimum;
        }

        //---------------------------------------------------------------------------------------------------

        //inserts node into skill tree at the next available empty spot
        public void InsertNode(SkillObject SO)
        {
            SkillNode current = Root;

            if (IsEmpty())
            {
                Debug.Log("[INSERT] - List is Empty, creating Root Node...");
                SkillNode newRootNode = new SkillNode(SO, false, ID_Assignment);
                ID_Assignment++;
                return;
            }

            //While loop searches next available spot to add the new Node
            while (current != null)
            {
                Debug.Log("[INSERT] - Creating new Node...");
                SkillNode newNode = new SkillNode(SO, false, ID_Assignment, current);
                ID_Assignment++;

                if (newNode.Skill_ID > current.Skill_ID)
                {
                    if (current.left == null)
                    {
                        current.left = newNode;
                        return;
                    }
                    else if (current.right == null)
                    {
                        current.right = newNode;
                        return;
                    }
                    else
                    {
                        //Allows movement through skill tree 
                        //to search for new empty spot
                        current = current.left;
                    }
                }
                else
                {
                    Debug.Log("[INSERT] - ID is a lower value than last node value...");
                }
            }

        }

        //---------------------------------------------------------------------------------------------------

    }
}
