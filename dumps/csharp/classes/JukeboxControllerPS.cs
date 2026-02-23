using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxControllerPS : ScriptableDeviceComponentPS
	{
		private JukeboxSetup _jukeboxSetup;
		private CInt32 _activeStation;
		private CBool _isPlaying;

		[Ordinal(107)] 
		[RED("jukeboxSetup")] 
		public JukeboxSetup JukeboxSetup
		{
			get => GetProperty(ref _jukeboxSetup);
			set => SetProperty(ref _jukeboxSetup, value);
		}

		[Ordinal(108)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetProperty(ref _activeStation);
			set => SetProperty(ref _activeStation, value);
		}

		[Ordinal(109)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}

		public JukeboxControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
