using NSubstitute;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTests
{
    [Test]
    public void PlayerEntering_PlayerTargetedTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        characterMover.IsPlayer.Returns(true);

        trap.HandleCharacterEntered(characterMover, TrapTargetType.Player); //acting in Arrange, Act Assert
        Assert.AreEqual(-1, characterMover.Health); //Assert
    }

    [Test]
    public void PlayerEntering_PlayerTargetedTrap_ReducesStrengthByOne()
    {
        Trap trap = new Trap();
        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        characterMover.IsPlayer.Returns(true);

        trap.HandleCharacterEntered(characterMover, TrapTargetType.Player);
        Assert.AreEqual(-1, characterMover.Strength);
    }

    [Test]
    public void NpcEntering_NpcTargetedTrap_ReducesHealthByOne()
    {
        Trap trap = new Trap();

        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover, TrapTargetType.Npc);
        Assert.AreEqual(-1, characterMover.Health);
    }

    [Test]
    public void VampireEntering_VampireTargetedTrap_AddsHealthByOne()
    {
        Trap trap = new Trap();

        ICharacterMover characterMover = Substitute.For<ICharacterMover>();
        trap.HandleCharacterEntered(characterMover, TrapTargetType.Vampire);
        Assert.AreEqual(+1, characterMover.Health);
    }
}
