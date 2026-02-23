using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapStubMappinController : gameuiBaseMinimapMappinController
	{
		private inkCompoundWidgetReference _regularIconContainer;
		private inkCompoundWidgetReference _preventionVehicleIconContainer;
		private wCHandle<gamemappinsStubMappin> _stubMappin;
		private CName _state;

		[Ordinal(14)] 
		[RED("regularIconContainer")] 
		public inkCompoundWidgetReference RegularIconContainer
		{
			get => GetProperty(ref _regularIconContainer);
			set => SetProperty(ref _regularIconContainer, value);
		}

		[Ordinal(15)] 
		[RED("preventionVehicleIconContainer")] 
		public inkCompoundWidgetReference PreventionVehicleIconContainer
		{
			get => GetProperty(ref _preventionVehicleIconContainer);
			set => SetProperty(ref _preventionVehicleIconContainer, value);
		}

		[Ordinal(16)] 
		[RED("stubMappin")] 
		public wCHandle<gamemappinsStubMappin> StubMappin
		{
			get => GetProperty(ref _stubMappin);
			set => SetProperty(ref _stubMappin, value);
		}

		[Ordinal(17)] 
		[RED("state")] 
		public CName State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public gameuiMinimapStubMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
