﻿// --------------------------------------------- -----------------------------------------------------------------------
// <summary>
//    Defines the OptionsViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.ViewModels.Options
{
    using System.Windows;

    using NinjaCoder.MvvmCross.Infrastructure.Services;
    using NinjaCoder.MvvmCross.Services.Interfaces;

    using Scorchio.VisualStudio.Services;

    using BaseViewModel = NinjaCoder.MvvmCross.ViewModels.BaseViewModel;

    /// <summary>
    ///  Defines the OptionsViewModel type.
    /// </summary>
    public class OptionsViewModel : BaseViewModel
    {
        /// <summary>
        /// The language dictionary.
        /// </summary>
        private ResourceDictionary languageDictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsViewModel" /> class.
        /// </summary>
        /// <param name="resolverService">The resolver service.</param>
        /// <param name="settingsService">The settings service.</param>
        public OptionsViewModel(
            IResolverService resolverService,
            ISettingsService settingsService)
            : base(settingsService)
        {
            TraceService.WriteLine("OptionsViewModel::Constructor Start");
            
            this.TracingViewModel = resolverService.Resolve<TracingViewModel>();
            this.BuildViewModel = resolverService.Resolve<BuildViewModel>();
            this.ProjectsViewModel = resolverService.Resolve<ProjectsViewModel>();
            this.CodingStyleViewModel = resolverService.Resolve<CodingStyleViewModel>();
            this.NugetViewModel = resolverService.Resolve<NugetViewModel>();
            this.VisualViewModel = resolverService.Resolve<VisualViewModel>();
            this.PluginsViewModel = resolverService.Resolve<PluginsViewModel>();
        }

        /// <summary>
        /// Gets the tracing view model.
        /// </summary>
        public TracingViewModel TracingViewModel { get; private set; }

        /// <summary>
        /// Gets the build view model.
        /// </summary>
        public BuildViewModel BuildViewModel { get; private set; }

        /// <summary>
        /// Gets the projects view model.
        /// </summary>
        public ProjectsViewModel ProjectsViewModel { get; private set; }

        /// <summary>
        /// Gets the coding style view model.
        /// </summary>
        public CodingStyleViewModel CodingStyleViewModel { get; private set; }

        /// <summary>
        /// Gets the plugins view model.
        /// </summary>
        public PluginsViewModel PluginsViewModel { get; private set; }
        
        /// <summary>
        /// Gets the nuget view model.
        /// </summary>
        public NugetViewModel NugetViewModel { get; private set; }

        /// <summary>
        /// Gets the visual view model.
        /// </summary>
        public VisualViewModel VisualViewModel { get; private set; }

        /// <summary>
        /// Gets or sets the language dictionary.
        /// </summary>
        public ResourceDictionary LanguageDictionary
        {
            get
            {
                return this.languageDictionary;
            }

            set
            {
                this.languageDictionary = value;
                this.BuildViewModel.LanguageDictionary = value;
                this.PluginsViewModel.LanguageDictionary = value;
                this.TracingViewModel.LanguageDictionary = value;
                this.ProjectsViewModel.LanguageDictionary = value;
                this.CodingStyleViewModel.LanguageDictionary = value;
                this.NugetViewModel.LanguageDictionary = value;
            }
        }

        /// <summary>
        /// Called when ok button pressed.
        /// </summary>
        public override void OnOk()
        {
            this.UpdateSettings();
            base.OnOk();
        }
       
        /// <summary>
        /// Updates the settings.
        /// </summary>
        internal void UpdateSettings()
        {
            this.TracingViewModel.Save();
            this.BuildViewModel.Save();
            this.ProjectsViewModel.Save();
            this.CodingStyleViewModel.Save();
            this.NugetViewModel.Save();
            this.VisualViewModel.Save();
            this.PluginsViewModel.Save();
        }
    }
}
