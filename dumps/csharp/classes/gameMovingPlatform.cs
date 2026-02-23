using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatform : entIPlacedComponent
	{
		private CEnum<gameMovingPlatformLoopType> _loopType;
		private CBool _supportLegacyUnalignedMarkers;
		private CBool _enableWaterInteractions;
		private CName _soundPositionName;

		[Ordinal(5)] 
		[RED("loopType")] 
		public CEnum<gameMovingPlatformLoopType> LoopType
		{
			get => GetProperty(ref _loopType);
			set => SetProperty(ref _loopType, value);
		}

		[Ordinal(6)] 
		[RED("supportLegacyUnalignedMarkers")] 
		public CBool SupportLegacyUnalignedMarkers
		{
			get => GetProperty(ref _supportLegacyUnalignedMarkers);
			set => SetProperty(ref _supportLegacyUnalignedMarkers, value);
		}

		[Ordinal(7)] 
		[RED("enableWaterInteractions")] 
		public CBool EnableWaterInteractions
		{
			get => GetProperty(ref _enableWaterInteractions);
			set => SetProperty(ref _enableWaterInteractions, value);
		}

		[Ordinal(8)] 
		[RED("soundPositionName")] 
		public CName SoundPositionName
		{
			get => GetProperty(ref _soundPositionName);
			set => SetProperty(ref _soundPositionName, value);
		}

		public gameMovingPlatform(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
