using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemGrenadeData : IScriptable
	{
		private CEnum<GrenadeDamageType> _type;
		private CFloat _range;
		private CEnum<gamedataGrenadeDeliveryMethodType> _deliveryMethod;
		private CFloat _duration;
		private CFloat _delay;
		private CFloat _detonationTimer;
		private CFloat _damagePerTick;
		private CEnum<gamedataStatType> _damageType;
		private CEnum<EGrenadeType> _grenadeType;
		private CFloat _totalDamage;
		private wCHandle<PlayerPuppet> _player;

		[Ordinal(0)] 
		[RED("Type")] 
		public CEnum<GrenadeDamageType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("Range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("DeliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get => GetProperty(ref _deliveryMethod);
			set => SetProperty(ref _deliveryMethod, value);
		}

		[Ordinal(3)] 
		[RED("Duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("Delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(5)] 
		[RED("DetonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetProperty(ref _detonationTimer);
			set => SetProperty(ref _detonationTimer, value);
		}

		[Ordinal(6)] 
		[RED("DamagePerTick")] 
		public CFloat DamagePerTick
		{
			get => GetProperty(ref _damagePerTick);
			set => SetProperty(ref _damagePerTick, value);
		}

		[Ordinal(7)] 
		[RED("DamageType")] 
		public CEnum<gamedataStatType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(8)] 
		[RED("GrenadeType")] 
		public CEnum<EGrenadeType> GrenadeType
		{
			get => GetProperty(ref _grenadeType);
			set => SetProperty(ref _grenadeType, value);
		}

		[Ordinal(9)] 
		[RED("TotalDamage")] 
		public CFloat TotalDamage
		{
			get => GetProperty(ref _totalDamage);
			set => SetProperty(ref _totalDamage, value);
		}

		[Ordinal(10)] 
		[RED("Player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public UIInventoryItemGrenadeData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
