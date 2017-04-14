﻿/*
 * Copyright 2017 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaSchemeCommon
 * Summary  : The class for transfer scheme components
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2017
 * Modified : 2017
 */

using Scada.Scheme.Model;
using System.Collections.Generic;

namespace Scada.Scheme.DataTransfer
{
    /// <summary>
    /// The class for transfer scheme components
    /// <para>Класс для передачи компонентов схемы</para>
    /// </summary>
    public class ComponentsDTO : SchemeDTO
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ComponentsDTO()
            : base()
        {
            EndOfComponents = false;
            Components = new List<BaseComponent>();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ComponentsDTO(int capacity)
            : base()
        {
            EndOfComponents = false;
            Components = new List<BaseComponent>(capacity);
        }


        /// <summary>
        /// Получить или установить признак, что считаны все компоненты схемы
        /// </summary>
        public bool EndOfComponents { get; set; }

        /// <summary>
        /// Получить компоненты схемы
        /// </summary>
        public List<BaseComponent> Components { get; private set; }
    }
}