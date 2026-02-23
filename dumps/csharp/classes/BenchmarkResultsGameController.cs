using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BenchmarkResultsGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _exitButton;
		private inkWidgetReference _settingButton;
		private inkCompoundWidgetReference _leftEntriesListContainer;
		private inkCompoundWidgetReference _rightEntriesListContainer;
		private CName _lineEntryName;
		private CName _highlightLineEntryName;
		private CName _sectionEntryName;
		private CHandle<worldBenchmarkSummary> _benchmarkSummary;
		private CHandle<inkGameNotificationToken> _exitRequestToken;
		private CBool _settingsAcive;

		[Ordinal(2)] 
		[RED("exitButton")] 
		public inkWidgetReference ExitButton
		{
			get => GetProperty(ref _exitButton);
			set => SetProperty(ref _exitButton, value);
		}

		[Ordinal(3)] 
		[RED("settingButton")] 
		public inkWidgetReference SettingButton
		{
			get => GetProperty(ref _settingButton);
			set => SetProperty(ref _settingButton, value);
		}

		[Ordinal(4)] 
		[RED("leftEntriesListContainer")] 
		public inkCompoundWidgetReference LeftEntriesListContainer
		{
			get => GetProperty(ref _leftEntriesListContainer);
			set => SetProperty(ref _leftEntriesListContainer, value);
		}

		[Ordinal(5)] 
		[RED("rightEntriesListContainer")] 
		public inkCompoundWidgetReference RightEntriesListContainer
		{
			get => GetProperty(ref _rightEntriesListContainer);
			set => SetProperty(ref _rightEntriesListContainer, value);
		}

		[Ordinal(6)] 
		[RED("lineEntryName")] 
		public CName LineEntryName
		{
			get => GetProperty(ref _lineEntryName);
			set => SetProperty(ref _lineEntryName, value);
		}

		[Ordinal(7)] 
		[RED("highlightLineEntryName")] 
		public CName HighlightLineEntryName
		{
			get => GetProperty(ref _highlightLineEntryName);
			set => SetProperty(ref _highlightLineEntryName, value);
		}

		[Ordinal(8)] 
		[RED("sectionEntryName")] 
		public CName SectionEntryName
		{
			get => GetProperty(ref _sectionEntryName);
			set => SetProperty(ref _sectionEntryName, value);
		}

		[Ordinal(9)] 
		[RED("benchmarkSummary")] 
		public CHandle<worldBenchmarkSummary> BenchmarkSummary
		{
			get => GetProperty(ref _benchmarkSummary);
			set => SetProperty(ref _benchmarkSummary, value);
		}

		[Ordinal(10)] 
		[RED("exitRequestToken")] 
		public CHandle<inkGameNotificationToken> ExitRequestToken
		{
			get => GetProperty(ref _exitRequestToken);
			set => SetProperty(ref _exitRequestToken, value);
		}

		[Ordinal(11)] 
		[RED("settingsAcive")] 
		public CBool SettingsAcive
		{
			get => GetProperty(ref _settingsAcive);
			set => SetProperty(ref _settingsAcive, value);
		}

		public BenchmarkResultsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
