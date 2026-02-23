using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseOnVisibilityBlockerAffectedTBHEvent : redEvent
	{
		private CFloat _newTBHModifier;

		[Ordinal(0)] 
		[RED("newTBHModifier")] 
		public CFloat NewTBHModifier
		{
			get => GetProperty(ref _newTBHModifier);
			set => SetProperty(ref _newTBHModifier, value);
		}

		public senseOnVisibilityBlockerAffectedTBHEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
