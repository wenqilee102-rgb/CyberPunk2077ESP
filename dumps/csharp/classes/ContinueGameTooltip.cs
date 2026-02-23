using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContinueGameTooltip : inkWidgetLogicController
	{
		private inkWidgetReference _mainContainer;
		private inkImageWidgetReference _imageReplacement;
		private inkWidgetReference _networkStatusError;
		private inkWidgetReference _networkSyncingIndicator;
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _labelDate;
		private inkTextWidgetReference _location;
		private inkTextWidgetReference _quest;
		private inkTextWidgetReference _level;
		private inkImageWidgetReference _lifepath;
		private inkImageWidgetReference _cloudStatus;
		private inkTextWidgetReference _playTime;
		private CEnum<inkSaveStatus> _saveFileStatus;
		private CEnum<servicesCloudSavesQueryStatus> _cloudSaveStatus;
		private CBool _metaDataLoaded;
		private CBool _isOffline;
		private redResourceReferenceScriptToken _defaultAtlasPath;

		[Ordinal(1)] 
		[RED("mainContainer")] 
		public inkWidgetReference MainContainer
		{
			get => GetProperty(ref _mainContainer);
			set => SetProperty(ref _mainContainer, value);
		}

		[Ordinal(2)] 
		[RED("imageReplacement")] 
		public inkImageWidgetReference ImageReplacement
		{
			get => GetProperty(ref _imageReplacement);
			set => SetProperty(ref _imageReplacement, value);
		}

		[Ordinal(3)] 
		[RED("networkStatusError")] 
		public inkWidgetReference NetworkStatusError
		{
			get => GetProperty(ref _networkStatusError);
			set => SetProperty(ref _networkStatusError, value);
		}

		[Ordinal(4)] 
		[RED("networkSyncingIndicator")] 
		public inkWidgetReference NetworkSyncingIndicator
		{
			get => GetProperty(ref _networkSyncingIndicator);
			set => SetProperty(ref _networkSyncingIndicator, value);
		}

		[Ordinal(5)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(6)] 
		[RED("labelDate")] 
		public inkTextWidgetReference LabelDate
		{
			get => GetProperty(ref _labelDate);
			set => SetProperty(ref _labelDate, value);
		}

		[Ordinal(7)] 
		[RED("location")] 
		public inkTextWidgetReference Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}

		[Ordinal(8)] 
		[RED("quest")] 
		public inkTextWidgetReference Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		[Ordinal(9)] 
		[RED("level")] 
		public inkTextWidgetReference Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(10)] 
		[RED("lifepath")] 
		public inkImageWidgetReference Lifepath
		{
			get => GetProperty(ref _lifepath);
			set => SetProperty(ref _lifepath, value);
		}

		[Ordinal(11)] 
		[RED("cloudStatus")] 
		public inkImageWidgetReference CloudStatus
		{
			get => GetProperty(ref _cloudStatus);
			set => SetProperty(ref _cloudStatus, value);
		}

		[Ordinal(12)] 
		[RED("playTime")] 
		public inkTextWidgetReference PlayTime
		{
			get => GetProperty(ref _playTime);
			set => SetProperty(ref _playTime, value);
		}

		[Ordinal(13)] 
		[RED("saveFileStatus")] 
		public CEnum<inkSaveStatus> SaveFileStatus
		{
			get => GetProperty(ref _saveFileStatus);
			set => SetProperty(ref _saveFileStatus, value);
		}

		[Ordinal(14)] 
		[RED("cloudSaveStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> CloudSaveStatus
		{
			get => GetProperty(ref _cloudSaveStatus);
			set => SetProperty(ref _cloudSaveStatus, value);
		}

		[Ordinal(15)] 
		[RED("metaDataLoaded")] 
		public CBool MetaDataLoaded
		{
			get => GetProperty(ref _metaDataLoaded);
			set => SetProperty(ref _metaDataLoaded, value);
		}

		[Ordinal(16)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetProperty(ref _isOffline);
			set => SetProperty(ref _isOffline, value);
		}

		[Ordinal(17)] 
		[RED("defaultAtlasPath")] 
		public redResourceReferenceScriptToken DefaultAtlasPath
		{
			get => GetProperty(ref _defaultAtlasPath);
			set => SetProperty(ref _defaultAtlasPath, value);
		}

		public ContinueGameTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
