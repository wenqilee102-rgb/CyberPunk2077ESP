using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetProgressionBuild : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataBuildType> _buildType;
		private CBool _isDebug;

		[Ordinal(1)] 
		[RED("buildType")] 
		public CEnum<gamedataBuildType> BuildType
		{
			get => GetProperty(ref _buildType);
			set => SetProperty(ref _buildType, value);
		}

		[Ordinal(2)] 
		[RED("isDebug")] 
		public CBool IsDebug
		{
			get => GetProperty(ref _isDebug);
			set => SetProperty(ref _isDebug, value);
		}

		public SetProgressionBuild(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
