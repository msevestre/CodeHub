using UIKit;
using MonoTouch.UIKit;

namespace CodeHub.iOS
{
    public static class Images
    {
        public static UIImage LoginUserUnknown { get { return UIImageHelper.FromFileAuto("Images/login_user_unknown").ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate); } }

        public static UIImage Avatar
        {
            get
            {
                var img = UIImageHelper.FromFileAuto("Images/avatar");
                img.AccessibilityLabel = "Avatar";
                return img;
            }
        }

        public static UIImage DownChevron
        {
            get
            {
                var img = CreateTemplateFromAuto("Images/down_chevron");
                img.AccessibilityElementsHidden = true;
                return img;
            }
        }

        public static class Logos
        {
            public static UIImage DotComMascot { get { return UIImage.FromFile("Images/Logos/dotcom-mascot.png"); } }
            public static UIImage EnterpriseMascot { get { return UIImage.FromFile("Images/Logos/enterprise-mascot.png"); } }
        }

        public static class Buttons
        {
            public static UIImage BlackButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/black_button");
                    img.AccessibilityElementsHidden = true;
                    return img;
                } 
            }

            public static UIImage GreyButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/grey_button");
                    img.AccessibilityElementsHidden = true;
                    return img;
                } 
            }

            public static UIImage CheckButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/check");
                    img.AccessibilityLabel = "Check";
                    return img;
                } 
            }

            public static UIImage BackButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/back");
                    img.AccessibilityLabel = "Back";
                    return img;
                } 
            }

            public static UIImage ThreeLinesButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/three_lines");
                    img.AccessibilityLabel = "Menu";
                    return img;
                }
            }

            public static UIImage CancelButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/cancel");
                    img.AccessibilityLabel = "Cancel";
                    return img;
                }
            }

            public static UIImage SortButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/sort");
                    img.AccessibilityLabel = "Sort";
                    return img;
                }
            }

            public static UIImage SaveButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Buttons/save");
                    img.AccessibilityLabel = "Save";
                    return img;
                }
            }
        }

        public static class Web
        {
            public static UIImage BackButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Web/back");
                    img.AccessibilityLabel = "Back";
                    return img;
                }
            }

            public static UIImage FowardButton
            {
                get
                {
                    var img = UIImageHelper.FromFileAuto("Images/Web/forward");
                    img.AccessibilityLabel = "Forward";
                    return img;
                }
            }
        }

        private static UIImage CreateTemplateFromAuto(string path)
        {
            return UIImageHelper.FromFileAuto(path);
        }
    }
}

