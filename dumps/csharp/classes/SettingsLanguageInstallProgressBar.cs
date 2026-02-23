using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsLanguageInstallProgressBar : inkWidgetLogicController
	{
		private inkWidgetReference _progressBarRoot;
		private inkWidgetReference _progressBarFill;
		private inkTextWidgetReference _textProgress;
		private CBool _isEnabled;

		[Ordinal(1)] 
		[RED("progressBarRoot")] 
		public inkWidgetReference ProgressBarRoot
		{
			get => GetProperty(ref _progressBarRoot);
			set => SetProperty(ref _progressBarRoot, value);
		}

		[Ordinal(2)] 
		[RED("progressBarFill")] 
		public inkWidgetReference ProgressBarFill
		{
			get => GetProperty(ref _progressBarFill);
			set => SetProperty(ref _progressBarFill, value);
		}

		[Ordinal(3)] 
		[RED("textProgress")] 
		public inkTextWidgetReference TextProgress
		{
			get => GetProperty(ref _textProgress);
			set => SetProperty(ref _textProgress, value);
		}

		[Ordinal(4)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public SettingsLanguageInstallProgressBar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
