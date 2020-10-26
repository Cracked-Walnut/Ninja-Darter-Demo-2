﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    [SerializeField] private Text _hpCurrentValue;
    [SerializeField] private Text _hpMaxValue;
    [SerializeField] private Text _armourCurrentValue;
    [SerializeField] private Text _armourMaxValue;
    [SerializeField] private Text _coinsCurrentValue;
    [SerializeField] private Text _pointsCurrentValue;
    [SerializeField] private Text _cubeFragmentsCurrentValue;
    [SerializeField] private Text _timerCurrentValue;
    [SerializeField] private Text _wristBladesCurrentValue;
    [SerializeField] private Text _arrowsCurrentValue;
    [SerializeField] private Text _arrowsMaxValue;
    [SerializeField] private GameObject _player;
    private Inventory _inventory;
    private XP _xp;
    private PlayerState _playerState;
    private Timer _timer;

    void Awake() { 
        _inventory = _player.GetComponent<Inventory>(); 
        _xp = _player.GetComponent<XP>();
        _playerState = _player.GetComponent<PlayerState>();
        _timer = _player.GetComponent<Timer>();
    }

    void Update() => UserInterface();

    void UserInterface() {
        _hpCurrentValue.text = _playerState.GetHealth().ToString();
        _hpMaxValue.text = _playerState.GetMaxHealth().ToString();
        _armourCurrentValue.text = _playerState.GetArmour().ToString();
        _armourMaxValue.text = _playerState.GetMaxArmour().ToString();
        _coinsCurrentValue.text = _inventory.GetCoins().ToString();
        _pointsCurrentValue.text = _xp.GetPoints().ToString();
        _cubeFragmentsCurrentValue.text = _inventory.GetCubeFragments().ToString();
        _wristBladesCurrentValue.text = _inventory.GetWristBlades().ToString();
        _arrowsCurrentValue.text = _inventory.GetArrows().ToString();
        _arrowsMaxValue.text = _inventory.GetMaxArrows().ToString();

        if (_timer.GetTimerRunning()) {
            _timer.StartTimer();
            string _roundedTotalTime = _timer.GetStageTime().ToString("#.00");
            _timerCurrentValue.text = _roundedTotalTime;
        }
    }
}
