using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DropPoint : BasicDistractionDevice
	{
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private gameNewMappinID _mappinID;
		private CBool _mappinInSystem;

		[Ordinal(106)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(107)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(108)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(109)] 
		[RED("mappinInSystem")] 
		public CBool MappinInSystem
		{
			get => GetProperty(ref _mappinInSystem);
			set => SetProperty(ref _mappinInSystem, value);
		}

		public DropPoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
