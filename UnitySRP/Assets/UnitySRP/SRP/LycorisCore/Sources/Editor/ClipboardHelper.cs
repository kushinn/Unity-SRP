using System;
using System.Reflection;
using UnityEngine;

namespace Lycoris
{
    public static class ClipboardHelper
    {
        private static PropertyInfo mSystemCopyBufferProperty = null;

        private static PropertyInfo GetSystemCopyBufferProperty()
        {
            if (mSystemCopyBufferProperty == null)
            {
                Type T = typeof(GUIUtility);
                mSystemCopyBufferProperty = T.GetProperty("systemCopyBuffer", BindingFlags.Static | BindingFlags.NonPublic);
                if (mSystemCopyBufferProperty == null)
                {
                    throw new Exception("Can't access internal member 'GUIUtility.systemCopyBuffer' it may have been removed / renamed");
                }
            }

            return mSystemCopyBufferProperty;
        }

        public static string ClipBoardString
        {
            get
            {
                PropertyInfo p = GetSystemCopyBufferProperty();
                if (p == null)
                    return string.Empty;
                return (string)p.GetValue(null, null);
            }

            set
            {
                PropertyInfo p = GetSystemCopyBufferProperty();
                if (p == null)
                    return;
                p.SetValue(null, value, null);
            }
        }
    }
}
