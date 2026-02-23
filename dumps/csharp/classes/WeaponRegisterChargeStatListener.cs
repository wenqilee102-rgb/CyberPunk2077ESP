using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponRegisterChargeStatListener : redEvent
	{
		private CBool _register;

		[Ordinal(0)] 
		[RED("register")] 
		public CBool Register
		{
			get => GetProperty(ref _register);
			set => SetProperty(ref _register, value);
		}

		public WeaponRegisterChargeStatListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
