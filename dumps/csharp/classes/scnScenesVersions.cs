using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersions : CResource
	{
		private CUInt32 _currentVersion;
		private CArray<scnScenesVersionsSceneChanges> _scenes;

		[Ordinal(1)] 
		[RED("currentVersion")] 
		public CUInt32 CurrentVersion
		{
			get => GetProperty(ref _currentVersion);
			set => SetProperty(ref _currentVersion, value);
		}

		[Ordinal(2)] 
		[RED("scenes")] 
		public CArray<scnScenesVersionsSceneChanges> Scenes
		{
			get => GetProperty(ref _scenes);
			set => SetProperty(ref _scenes, value);
		}

		public scnScenesVersions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
