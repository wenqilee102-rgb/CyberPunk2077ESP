using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PulseAnimation : IScriptable
	{
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _anim;
		private CFloat _top;
		private CFloat _bot;
		private CFloat _time;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(1)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(2)] 
		[RED("top")] 
		public CFloat Top
		{
			get => GetProperty(ref _top);
			set => SetProperty(ref _top, value);
		}

		[Ordinal(3)] 
		[RED("bot")] 
		public CFloat Bot
		{
			get => GetProperty(ref _bot);
			set => SetProperty(ref _bot, value);
		}

		[Ordinal(4)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(5)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public PulseAnimation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
