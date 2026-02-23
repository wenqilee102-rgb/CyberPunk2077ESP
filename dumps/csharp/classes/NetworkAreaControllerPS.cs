using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkAreaControllerPS : MasterControllerPS
	{
		private CBool _isActive;
		private CUInt32 _visualizerID;
		private CBool _hudActivated;
		private CInt32 _currentlyAvailableCharges;
		private CInt32 _maxAvailableCharges;

		[Ordinal(108)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(109)] 
		[RED("visualizerID")] 
		public CUInt32 VisualizerID
		{
			get => GetProperty(ref _visualizerID);
			set => SetProperty(ref _visualizerID, value);
		}

		[Ordinal(110)] 
		[RED("hudActivated")] 
		public CBool HudActivated
		{
			get => GetProperty(ref _hudActivated);
			set => SetProperty(ref _hudActivated, value);
		}

		[Ordinal(111)] 
		[RED("currentlyAvailableCharges")] 
		public CInt32 CurrentlyAvailableCharges
		{
			get => GetProperty(ref _currentlyAvailableCharges);
			set => SetProperty(ref _currentlyAvailableCharges, value);
		}

		[Ordinal(112)] 
		[RED("maxAvailableCharges")] 
		public CInt32 MaxAvailableCharges
		{
			get => GetProperty(ref _maxAvailableCharges);
			set => SetProperty(ref _maxAvailableCharges, value);
		}

		public NetworkAreaControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
