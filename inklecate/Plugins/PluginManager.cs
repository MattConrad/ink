using System;
using System.Collections.Generic;

namespace Ink
{
    internal class PluginManager
    {
        public PluginManager (List<string> pluginNames)
        {
            _plugins = new List<IPlugin> ();

            // TODO: Make these plugin names DLL filenames, and load up their assemblies
            foreach (string pluginName in pluginNames) {
                if (pluginName == "ChoiceListPlugin") {
                    _plugins.Add (new InkPlugin.ChoiceListPlugin ());
                } else {
                    //.NET Core doesn't support SystemException.
                    //throw new SystemException ("Plugin not found");
                    throw new Exception("Plugin not found");
                }
            }
        }

        public void PostParse(Parsed.Story parsedStory)
        {
            foreach (var plugin in _plugins) {
                plugin.PostParse (parsedStory);
            }
        }

        public void PostExport(Parsed.Story parsedStory, Runtime.Story runtimeStory)
        {
            foreach (var plugin in _plugins) {
                plugin.PostExport (parsedStory, runtimeStory);
            }
        }

        List<IPlugin> _plugins;
    }
}

