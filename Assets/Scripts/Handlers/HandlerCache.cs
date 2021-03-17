using System.Collections.Generic;
using Core;

namespace Handlers
{
    public static class HandlerCache<T> where T: ICachable
    { 
        
        public static T SetData<M>(IBot bot, T instance) where M: IMechanic
        {           
            Cache<T>.Set<M>(instance);
            Bot.DataCache.Add(bot.ID, Cache<IData>.Storage);
            return instance;
        }
        
        public static T[] GetData(IBot bot)
        {           
            var data =  new Dictionary<IMechanic, IData>();
            Bot.DataCache.TryGetValue(bot.ID, out data);
            
            IData[] dataArray = new IData[data.Count];    
            data.Values.CopyTo(dataArray, 0);
            return dataArray as T[];
        }

        public static T SetAction<M>(IBot bot, T instance) where M: IMechanic
        {           
            Cache<T>.Set<M>(instance);
            Bot.ActionCache.Add(bot.ID, Cache<IAction>.Storage);
            return instance;
        }
        
        public static T[] GetAction(IBot bot)
        {           
            var data =  new Dictionary<IMechanic, IAction>();
            Bot.ActionCache.TryGetValue(bot.ID, out data);
            
            IAction[] dataArray = new IAction[data.Count];    
            data.Values.CopyTo(dataArray, 0);
            return dataArray as T[];
        }
        
    }
}