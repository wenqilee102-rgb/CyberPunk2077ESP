using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MaxTacFearEvent : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _player;
		private wCHandle<gameObject> _av;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("av")] 
		public wCHandle<gameObject> Av
		{
			get => GetProperty(ref _av);
			set => SetProperty(ref _av, value);
		}

		public MaxTacFearEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
