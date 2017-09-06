using PenappleWindowsApp.ViewModels;
using PenappleWindowsApp.Views;
using PenscribCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenappleWindowsApp.Api;
using Windows.UI.Input.Inking;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using PenappleWindowsApp.Models;

namespace PenappleWindowsApp
{
    /// <summary>
    /// GroupsContent
    /// 
    /// Class to represent the content of a group that 
    /// will be displayed in the groups screen
    /// 
    /// author: Eric LaBouve
    /// </summary>
    public class GroupsContent
    {
        public GroupChat group { get; }
        public string groupName { get; set; }
        public string groupMembers { get; }
        public String groupIcon { get; set; }
        // Each group has their own message history
        public MessageHistoryViewModel messageHistoryViewModel;

        // The specific background to load
        // SHOULD FIX THIS PORTION TO BE MORE SCALABLE
        public string backgroundPath { get; set; }
        public ImageContainer imageContainer { get; set; }
        // The specific strokes to load
        public InkStrokeContainer strokes { get; set; }

        public GroupsContent(GroupChat groupChat, string groupMembers)
        {
            group = groupChat;

            groupName = this.group.Name;
            groupIcon = getGroupIconChars(groupName);

            this.groupMembers = groupMembers;

            backgroundPath = null;
            imageContainer = null;
            strokes = new InkStrokeContainer();

            messageHistoryViewModel = new MessageHistoryViewModel(this);
        }

        /// <summary>
        /// Sets the text to represent a group icon
        /// </summary>
        /// <param name="gName">Name of the group</param>
        /// <return>The letters representing the icon for the group</return>
        public static String getGroupIconChars(string gName)
        {
            if (String.IsNullOrWhiteSpace(gName))
            {
                return "GC";
            }
            else
            {
                String icon = "";
                String[] tokens = gName.Trim().Split(' ');

                for (int i = 0; i < tokens.Length && icon.Length < 2; ++i)
                {
                    icon += tokens[i][0];
                }

                return icon.ToUpper();
            }
        }

        /// <summary>
        /// Determines if a group was updated based on the members in the group or the name of the group
        /// </summary>
        /// <param name="newGroup">Group to compare to</param>
        /// <return>True if the group members are different</return>
        public bool isUpdated(GroupsContent newGroup)
        {
            // check for matching ids, then check if the group members have changed
            if (group.id == newGroup.group.id && 
                groupMembers == newGroup.groupMembers &&
                group.Name == newGroup.group.Name)
            {
                return false;
            }

            return true;
        }

        // updates the canvas portion of the groups content
        public void updateCanvasFrom(GroupsContent gc)
        {
            strokes = gc.strokes;
            backgroundPath = gc.backgroundPath;
            imageContainer = gc.imageContainer;
        }

        public override bool Equals(object obj)
        {
            var mc = obj as GroupsContent;

            if (mc == null)
            {
                return false;
            }

           return this.group.id.Length > 0 && this.group.id == mc.group.id;
        }
    }
}
