// ***********************************************************************
// Assembly         : ACBr.Net.Boleto
// Author           : RFTD
// Created          : 04-17-2014
//
// Last Modified By : RFTD
// Last Modified On : 04-23-2014
// ***********************************************************************
// <copyright file="IBoletoFCClass.cs" company="ACBr.Net">
//     Copyright (c) ACBr.Net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Linq;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

/// <summary>
/// The Interfaces namespace.
/// </summary>
namespace ACBr.Net.Boleto.Interfaces
{
    /// <summary>
    /// Interface IBoletoFCClass
    /// </summary>
    public interface IBoletoPrinter
    {
        #region Propriedades

        /// <summary>
        /// Gets or sets the layout.
        /// </summary>
        /// <value>The layout.</value>
        LayoutBoleto Layout { get; set; }
        /// <summary>
        /// Gets the boleto.
        /// </summary>
        /// <value>The boleto.</value>
        ACBrBoleto Boleto { get; }
        /// <summary>
        /// Gets or sets the dir logo.
        /// </summary>
        /// <value>The dir logo.</value>
        string DirLogo { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [mostrar preview].
        /// </summary>
        /// <value><c>true</c> if [mostrar preview]; otherwise, <c>false</c>.</value>
        bool MostrarPreview { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [mostrar setup].
        /// </summary>
        /// <value><c>true</c> if [mostrar setup]; otherwise, <c>false</c>.</value>
        bool MostrarSetup { get; set; }
        /// <summary>
        /// Gets or sets the number copias.
        /// </summary>
        /// <value>The number copias.</value>
        int NumCopias { get; set; }
        /// <summary>
        /// Gets or sets the filtro.
        /// </summary>
        /// <value>The filtro.</value>
        BoletoFCFiltro Filtro { get; set; }
        /// <summary>
        /// Gets or sets the nome arquivo.
        /// </summary>
        /// <value>The nome arquivo.</value>
        string NomeArquivo { get; set; }
        /// <summary>
        /// Gets or sets the software house.
        /// </summary>
        /// <value>The software house.</value>
        string SoftwareHouse { get; set; }

        #endregion Propriedades

        #region Methods

        /// <summary>
        /// Imprimirs this instance.
        /// </summary>
        void Imprimir();
        /// <summary>
        /// Gerars the PDF.
        /// </summary>
        void GerarPDF();
        /// <summary>
        /// Gerars the HTML.
        /// </summary>
        void GerarHTML();
        /// <summary>
        /// Carregas the logo.
        /// </summary>
        /// <param name="PictureLogo">The picture logo.</param>
        /// <param name="NumeroBanco">The numero banco.</param>
        void CarregaLogo(ref Image PictureLogo, int NumeroBanco);

        #endregion Methods
    }
}