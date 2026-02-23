using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayOnePunchVFX : redEvent
	{
		private wCHandle<gameObject> _target;
		private wCHandle<gameObject> _instigator;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		public PlayOnePunchVFX(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
