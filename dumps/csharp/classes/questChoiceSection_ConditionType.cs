using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questChoiceSection_ConditionType : questISceneConditionType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CEnum<scnSceneVersionCheck> _sceneVersion;
		private scnNodeId _choiceSectionId;
		private CName _choiceSectionName;
		private CName _optionName;
		private CEnum<questChoiceSection_ConditionTypeMode> _mode;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetProperty(ref _sceneVersion);
			set => SetProperty(ref _sceneVersion, value);
		}

		[Ordinal(2)] 
		[RED("choiceSectionId")] 
		public scnNodeId ChoiceSectionId
		{
			get => GetProperty(ref _choiceSectionId);
			set => SetProperty(ref _choiceSectionId, value);
		}

		[Ordinal(3)] 
		[RED("choiceSectionName")] 
		public CName ChoiceSectionName
		{
			get => GetProperty(ref _choiceSectionName);
			set => SetProperty(ref _choiceSectionName, value);
		}

		[Ordinal(4)] 
		[RED("optionName")] 
		public CName OptionName
		{
			get => GetProperty(ref _optionName);
			set => SetProperty(ref _optionName, value);
		}

		[Ordinal(5)] 
		[RED("mode")] 
		public CEnum<questChoiceSection_ConditionTypeMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public questChoiceSection_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
