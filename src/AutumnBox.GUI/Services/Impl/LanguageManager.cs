﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/8/17 15:11:15 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.GUI.Properties;
using AutumnBox.Leafx.Container.Support;
using System;
using System.Collections.Generic;
using System.Windows;

namespace AutumnBox.GUI.Services.Impl
{
    /// <summary>
    /// 语言管理器
    /// </summary>

    //sealed class LanguageManager : ILanguageManager
    //{
    //    private const int INDEX_OF_LANG = 0;
    //    private const string FILE_PATH = "pack://application:,,,/AutumnBox.GUI;component/Resources/Languages/";
    //    private const string LANG_NAME_KEY = "LanguageName";
    //    private const string LANG_CODE_KEY = "LanguageCode";
    //    private const string DEFAULT_LANG_CODE = "en-US";

    //    public ILanguage Current
    //    {
    //        get
    //        {
    //            return GetCurrent();
    //        }
    //        set
    //        {
    //            Apply(value);
    //        }
    //    }

    //    public IEnumerable<ILanguage> Languages => languages;
    //    private List<Language> languages;

    //    public event EventHandler LanguageChanged;

    //    public LanguageManager()
    //    {
    //        AllLoad();
    //    }
    //    private void AllLoad()
    //    {
    //        languages = new List<Language>
    //        {
    //            Language.From("zh-CN.xaml"),
    //            Language.From("en-US.xaml"),
    //        };
    //        Current = languages.Find((_l) =>
    //        {
    //            return _l.LanCode == App.Current.Resources["LanguageCode"].ToString();
    //        });
    //    }
    //    private ILanguage GetCurrent()
    //    {
    //        var code = App.Current.Resources[LANG_CODE_KEY].ToString();
    //        return languages.Find((t) =>
    //        {
    //            return t.LanCode == code;
    //        });
    //    }
    //    private void Apply(ILanguage lang)
    //    {
    //        if (Current.Equals(lang))
    //        {
    //            return;
    //        }
    //        App.Current.Resources.MergedDictionaries[INDEX_OF_LANG] = lang.Resource;
    //        Settings.Default.Language = lang.LanCode;
    //        Settings.Default.Save();
    //        LanguageChanged?.Invoke(this, new EventArgs());
    //    }
    //    public void ApplyBySetting()
    //    {
    //        ApplyByLanguageCode(Settings.Default.Language);
    //    }
    //    public void ApplyByEnvoriment()
    //    {
    //        switch (System.Threading.Thread.CurrentThread.CurrentCulture.Name)
    //        {
    //            case "zh-TW":
    //            case "zh-CN":
    //            case "zh-SG":
    //            case "zh-HK":
    //                ApplyByLanguageCode("zh-CN");
    //                break;
    //            default:
    //                ApplyByLanguageCode(DEFAULT_LANG_CODE);
    //                break;
    //        }
    //    }
    //    public void ApplyByLanguageCode(string langCode)
    //    {
    //        var lang = languages.Find((_lang) => _lang.LanCode == langCode);
    //        if (lang != null)
    //        {
    //            Apply(lang);
    //        }
    //        else
    //        {
    //            ApplyByLanguageCode(DEFAULT_LANG_CODE);
    //        }
    //    }
    //    private class Language : ILanguage
    //    {
    //        public string LangName => Resource[LANG_NAME_KEY].ToString();
    //        public string LanCode => Resource[LANG_CODE_KEY].ToString();
    //        public ResourceDictionary Resource { get; private set; }
    //        private Language() { }
    //        public static Language From(string fileName)
    //        {
    //            var resouceDict = new ResourceDictionary { Source = new Uri(FILE_PATH + fileName) };
    //            return new Language()
    //            {
    //                Resource = resouceDict,
    //            };
    //        }

    //        public bool Equals(ILanguage other)
    //        {
    //            return other != null && other.LanCode == this.LanCode;
    //        }

    //        public override bool Equals(object obj)
    //        {
    //            return Equals(obj as ILanguage);
    //        }

    //        public override int GetHashCode()
    //        {
    //            var hashCode = -775359848;
    //            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LangName);
    //            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LanCode);
    //            hashCode = hashCode * -1521134295 + EqualityComparer<ResourceDictionary>.Default.GetHashCode(Resource);
    //            return hashCode;
    //        }

    //        public static bool operator ==(Language language1, Language language2)
    //        {
    //            return language1.Equals(language2);
    //        }

    //        public static bool operator !=(Language language1, Language language2)
    //        {
    //            return !(language1 == language2);
    //        }
    //    }
    //}
}
