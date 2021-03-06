﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ReactiveUI;

namespace AutoRepair.Model
{
    public class Client : ReactiveObject
    {
        #region Constructors

        public Client() { }

        public Client(string firstname, string lastName, string patronymic, string personalId, string phoneNumber, string address)
        {
            _firstname   = firstname;
            _lastName    = lastName;
            _patronymic  = patronymic;
            _personalId  = personalId;
            _phoneNumber = phoneNumber;
            _address     = address;
        }

        #endregion

        #region ClientIDProperty

        private int _clientId;
        [Display(AutoGenerateField = false)]
        public int ClientId
        {
            get => _clientId;
            set => this.RaiseAndSetIfChanged(ref _clientId, value);
        }

        #endregion

        #region FirstNameProperty

        private string _firstname;
        [Required][Display(Name = "Имя")]
        public string FirstName
        {
            get => _firstname;
            set => this.RaiseAndSetIfChanged(ref _firstname, value);
        }

        #endregion

        #region LastNameProperty

        private string _lastName;
        [Required][Display(Name = "Фамилия")]
        public string LastName
        {
            get => _lastName;
            set => this.RaiseAndSetIfChanged(ref _lastName, value);
        }

        #endregion

        #region PatronymicProperty

        private string _patronymic;
        [Display(Name = "Отчество")]
        public string Patronymic
        {
            get => _patronymic;
            set => this.RaiseAndSetIfChanged(ref _patronymic, value);
        }

        #endregion

        #region PersonalIDProperty

        private string _personalId;
        [Required][Display(Name = "№ Уд.Личности")]
        public string PersonalId
        {
            get => _personalId;
            set => this.RaiseAndSetIfChanged(ref _personalId, value);
        }

        #endregion

        #region PhoneNumberProperty

        private string _phoneNumber;
        [Required][Display(Name = "№ Телефона")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => this.RaiseAndSetIfChanged(ref _phoneNumber, value);
        }

        #endregion

        #region AddressProperty

        private string _address;
        [Display(Name = "Адрес")]
        public string Address
        {
            get => _address;
            set => this.RaiseAndSetIfChanged(ref _address, value);
        }

        #endregion

        #region ClientCarsProperty

        private List<Car> _carsList;

        [Browsable(false)]
        public List<Car> ClientCars
        {
            get => _carsList;
            set => this.RaiseAndSetIfChanged(ref _carsList, value);
        }

        #endregion
    }
}