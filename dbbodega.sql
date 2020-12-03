-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 03-12-2020 a las 14:16:16
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dbbodega`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detallefactura`
--

CREATE TABLE `detallefactura` (
  `iddetalleFactura` int(11) NOT NULL,
  `cantidadProducto` int(11) DEFAULT NULL,
  `Productos_idProductos` int(11) NOT NULL,
  `Factura_idFactura` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `detallefactura`
--

INSERT INTO `detallefactura` (`iddetalleFactura`, `cantidadProducto`, `Productos_idProductos`, `Factura_idFactura`) VALUES
(2, 7, 99009, 6),
(4, 10, 21389, 8),
(5, 5, 5, 9),
(7, 7, 9999, 11);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `factura`
--

CREATE TABLE `factura` (
  `idFactura` int(11) NOT NULL,
  `Fecha` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `factura`
--

INSERT INTO `factura` (`idFactura`, `Fecha`) VALUES
(0, '2020-11-29 18:20:00'),
(1, '2020-11-29 18:21:00'),
(2, '2020-11-29 18:22:00'),
(3, '2020-11-29 18:23:00'),
(4, '2020-11-29 18:24:00'),
(5, '2020-12-03 09:08:20'),
(6, '2020-12-03 09:23:48'),
(7, '2020-12-03 09:46:24'),
(8, '2020-12-03 09:46:53'),
(9, '2020-12-03 09:58:39'),
(10, '2020-12-03 10:01:37'),
(11, '2020-12-03 10:02:39');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `idProductos` int(11) NOT NULL,
  `nombreProducto` varchar(150) DEFAULT NULL,
  `Stock` int(11) DEFAULT NULL,
  `Precio` int(11) DEFAULT NULL,
  `Proveedor_idProveedor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idProductos`, `nombreProducto`, `Stock`, `Precio`, `Proveedor_idProveedor`) VALUES
(2, 'Mousepad', 150, 1500, 0),
(4, 'Teclado Genius', 15, 15000, 0),
(5, 'Harman Kardon Speaker', 55, 60000, 0),
(9999, 'Galletas', 93, 1000, 0),
(21389, 'Hotwheels', 190, 7990, 0),
(43243, 'Plastilina 10cm', 200, 4500, 0),
(99009, 'Giramundo', 93, 6000, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL,
  `Nombre` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `Nombre`) VALUES
(0, 'Rigoberto Lastarria'),
(1, 'Godofredo Arias'),
(2, 'Eliodoro Ramirez'),
(3, 'Aurelio Soto'),
(4, 'Tulio Triviño');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD PRIMARY KEY (`iddetalleFactura`),
  ADD KEY `fk_detalleFactura_Productos1_idx` (`Productos_idProductos`),
  ADD KEY `fk_detalleFactura_Factura1_idx` (`Factura_idFactura`);

--
-- Indices de la tabla `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`idFactura`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`idProductos`),
  ADD KEY `fk_Productos_Proveedor_idx` (`Proveedor_idProveedor`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  MODIFY `iddetalleFactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `factura`
--
ALTER TABLE `factura`
  MODIFY `idFactura` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detallefactura`
--
ALTER TABLE `detallefactura`
  ADD CONSTRAINT `fk_detalleFactura_Factura1` FOREIGN KEY (`Factura_idFactura`) REFERENCES `factura` (`idFactura`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_detalleFactura_Productos1` FOREIGN KEY (`Productos_idProductos`) REFERENCES `productos` (`idProductos`) ON DELETE CASCADE;

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `fk_Productos_Proveedor` FOREIGN KEY (`Proveedor_idProveedor`) REFERENCES `proveedor` (`idProveedor`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
