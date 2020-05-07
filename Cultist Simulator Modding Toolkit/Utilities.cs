﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultist_Simulator_Modding_Toolkit
{
    public static class Utilities
    {
        public static List<ModViewer> currentMods = new List<ModViewer>();

        public static Image getAspectImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory+"/images/icons40/aspects/"+id+".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/icons40/aspects/" + id + ".png");
                }
            }
            return null;
        }

        public static Image getElementImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory + "/images/elementArt/" + id + ".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/elementArt/" + id + ".png");
                }
            }
            return null;
        }

        public static Image getEndingImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory + "/images/endingArt/" + id + ".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/endingArt/" + id + ".png");
                }
            }
            return null;
        }

        public static Image getLegacyImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory + "/images/icons100/legacies/" + id + ".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/icons100/legacies/" + id + ".png");
                }
            }
            return null;
        }

        public static Image getVerbImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory + "/images/icons100/verbs/" + id + ".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/icons100/verbs/" + id + ".png");
                }
            }
            return null;
        }

        public static Image getCardBackImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory + "/images/cardBacks/" + id + ".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/cardBacks/" + id + ".png");
                }
            }
            return null;
        }

        public static Image getBurnImage(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (File.Exists(mv.currentDirectory + "/images/burnImages/" + id + ".png"))
                {
                    return Image.FromFile(mv.currentDirectory + "/images/burnImages/" + id + ".png");
                }
            }
            return null;
        }

        public static bool aspectExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.aspectExists(id)) return true;
            }
            return false;
        }

        public static Aspect getAspect(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getAspect(id) != null)
                {
                    return mv.getAspect(id);
                }
            }
            return null;
        }

        public static bool elementExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.elementExists(id)) return true;
            }
            return false;
        }

        public static Element getElement(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getElement(id) != null)
                {
                    return mv.getElement(id);
                }
            }
            return null;
        }

        public static bool recipeExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.recipeExists(id)) return true;
            }
            return false;
        }

        public static Recipe getRecipe(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getRecipe(id) != null)
                {
                    return mv.getRecipe(id);
                }
            }
            return null;
        }

        public static bool deckExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.recipeExists(id)) return true;
            }
            return false;
        }

        public static Deck getDeck(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getDeck(id) != null)
                {
                    return mv.getDeck(id);
                }
            }
            return null;
        }

        public static bool legacyExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.legacyExists(id)) return true;
            }
            return false;
        }

        public static Legacy getLegacy(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getLegacy(id) != null)
                {
                    return mv.getLegacy(id);
                }
            }
            return null;
        }

        public static bool endingExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.endingExists(id)) return true;
            }
            return false;
        }

        public static Ending getEnding(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getEnding(id) != null)
                {
                    return mv.getEnding(id);
                }
            }
            return null;
        }

        public static bool verbExists(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.verbExists(id)) return true;
            }
            return false;
        }

        public static Verb getVerb(string id)
        {
            foreach (ModViewer mv in currentMods)
            {
                if (mv.getVerb(id) != null)
                {
                    return mv.getVerb(id);
                }
            }
            return null;
        }
    }
}
