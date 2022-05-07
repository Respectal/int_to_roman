# Roman numerals generator
## Algorithm
![roman numerals table](data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAASoAAAE7CAYAAABqsMwRAAAAAXNSR0IArs4c6QAAIABJREFUeF7tfe+PXkWW3uFvWBxWggiN20T+ksg7JCtYY9rjkTugVYjlaTk9Ym0N7cE9lqJR9oObAV78wbSBaX/YaL4wbdY9IzNoHNTTIhMli9paxm3MgjZht5V8sWK3EQoTZQP5GxzVvbfurapbVafqvbfeuvXW6U/grl/nqec8depH3/PA/fv37wP9EAKEACEwYAQeIKEa8OzQ0AgBQqBAgISKiEAIEAKDR4CEavBTRAMkBAgBEqqCA38Pb+ydh3cOvwl/u34C9ozFC7WN6v/hh/Cbey/Dt5E2v944DX+8fAO+s/oZrM/rRvA1/IfFJ+AnN9zaczHh796age9dBnjx/V145Z871Phvb8K3TvylZYwObQhFvPv3ax46t/9/3ofFP3kZfteJF56DpuJaBEiogglV34ybPqHqGyG1PRKq0AhPrn0SKp1QCSvpW//kZfjJ5XJC1GiHOwL73YvvbwCcEKMyMaL6IdxpRUNceA7DW39zBY7cakdUPMoq+96Af/lf5oWIShOxtSIe3kdDKNEG3JF5H6z+D+E37wN8T42oOFZVF62IsBoTH4EYvcn9C3is7oOfLP+lgDlU0WQ1jjpC7WZf3f/qm3B3+WX4XdGjELG2Iip7f6y2OGcA5dz+mz9s8Bc5I/XFiihYAUVyNXAkVDahai0YDfFkQgoFa3LJQvKPq61d7aiKE4C69VNJW3fBHQkXKtkpeAONDXahajslb6EWI0WkWmJksIFjoBcqFfTD8J3DN+B3N4R/P7MBX/zkj+qtnVzD1T4w1AeoBUKZo/9VbZVN/ek50R6PVJ/zxYAlVLZOLnYZZk8kVFah4iRrnLZ0sibSqIWHO6VBqL7NiVgRTz2Tkv+/iSDaouAuVCrlVGGyClUtMk2EwcvzMfExN1GSeE73HfioiCKFMzDepiI0Zf0GY95+LbQc0xbGsoVe9oEgVLUY8Hmt5h3sZ1Ryf0rdP2yiq9Ker1rnoBJ+j1R9kTBplZKEyiZUQuitJZUUmmOH6eIZU3srKAtVRWrpIF49o8IjKj7j6kqvj2hkfmgP95WtpT5i49unZ+BDdkFhuUwwbv2q7VJrDIbD7XHsY6Ms+5e3Z/g8q9u7Soi50Ji2a6aIqT5SELe35VyYL1aGGfWEHBUJ1cSEqiH4i/xMRFg9+xAq1bGxCMMWUXUTKub8/xZ2/ySsUPGtmEl4sTM43e9tQmXtr4NQyds78VxQ2IaGVIEE2iahGkeoNFu/elU3bf1YP8qqKh4so1u/1lZM3WqoWyc1KlO3r83WR/s8odVfe2vW3vqJjG+Xr+2vMJIdX75cYAfQ9ojqMXhHitg87fPe+mH9WY4DigUJPJ/AtPFIQE+CDZGEaiyhaof/9QzZhEp0DmVL1HJK9DAdO+zmQtXmjsvWDwBrf09LeOueeKQ41mF6+8KidU5XYMyFY1z7fA/T8f7GOkznN4NflW/UWj9081dAQkI1plA1Zxz8POFN2Lf8svBo1PDgUzlQVs+RxHMJifhn3oS3/ufL8oNPKULTPB8QhYIR/g2Al9gDRu1htm4xFLchh+Gt6tmAdHainr2ojqWIlfl5hG9EdQL2dLTP+3kC0h9D0HRextFVz/WkaLYl7P097g0W6kyoYRKqCQFN3QwPAewMa3gjzndEJFT5zn32lpNQpUMBEqp05opG2jMCJFQ9AxqwORKqgOBS04QAIdAPAiRU/eBIrRAChEBABEioAoJLTRMChEA/CJBQ9YMjtUIIEAIBEWgJ1bvv/zZgd9Q0IUAIEAJuCJw88VxdUCtUz3x31q0lh1If/vU29NmeQ5fZFCFs/ac6F8xSt5ONn4TKn9+DrJE6GWOAmgtmqdtJQhXDOwL1mToZA8FibTYXzFK3k4QqhncE6jN1MgaChYQKAFLnBglVDO8I1GfqZAwECwkVCZU/tciZ/DFzrUHYuiLVlMsFs9TtpIjKn9uDrZE6GWMAmwtmqdtJQhXDOwL1mToZA8FCWz/a+vlTi5zJHzPXGoStK1K09fNHKm6NYUVUO38Bf/ziu0ZEDp7fgsUv5uD0uwB/9s7fwY8PxAWv194r25mNf/GvHhyraZtQ/b//9GN49sItaLXPMT/5S/jbH/+zsfp1qcT773fevoH/+O/m4OInJ+HKf/1z+KcuA1HKjC/uvG9Tp+OPaQwz0Cp2O/87/Oxf/AB+BeqYuY1Pwav/+Wfwr/8R2g3A//0A/vxPL8AnB8/DX/37Y/AHrArj2M3vduIXCZUD9hMpQkI1BswkVK6gTUyo1AH1tBAOS6hEIw0G/o+ffbuKqLbg0V+y1ZRVMq0EvEH5900bPCqrVhRhFeARQD0kKeJor6ZipFK3f/48fHHhAhRDbI2Rr2LV794BOP3iu0LE0+4Di0b6iKjakZcqBs3q++r5L+DihVslRGpExldW9ruD5+HKdz+C0xdu1ZFwjdHJk/Crd1kUXc2RWK+oKkeY4rwcPP9LOPzXP5AjKjUqF1d2jVePH1GJjekjD5lDclTS4HwevnXhAvyqaE6JXDxtsYlWX0KFcluMqH7wBTwr7ZC4H4rc19htmKdh/gkNIlQtW2pHMYXkDQlQoTJsQbnT8PryGNrt+4+xcUysDx0pJytU7RE0QqoSsSnLy7TsY/O3cK/cNihN1+0ajwb0IqdfZOTGQwlVa6FTFiv970tRL7ZMimC72DJJoTJyGxWqk3Cv2K6rLdi3yslGVPUKru6JOZl10VElZq5C5XpepLZXOyEXT3VMtcM1k8PryGLocTaA3OwYHaMOOsszKveIqjknVMde91XPQbN4tIRKiMTa51hipPsU3KoIXs9L7cyKUHmct4URKs2WVNnatzDqwZaJCpWJ2yZ/bAUSfmd4yQpVa/WunOJ/11tD8bBd3tq1y6hbv3ZEoNt2qc6vOqFpjKA72FbPqFrRAz6xLhGVkcwVkdyFShiPMvb2QgC1AJoxAtBHkXzb/F34XevAVxUE+5bcNwq1Ob78O3XrZ44o+QKL4+xvyySFysTtOhLki5RmZ9RaNJHtObNr6oSKi4AsLIhQ6W4qGDpq+G2IyEwRVSehqlhnEkNfp3O99WuXU2+ENDdEwYWKRZY/hC//VL2ZMh2mK0JhcYQwEZVFqKqxtBer7rakIlR8nPLCZN89TJ1Q/YHH1o9vIdpbFXXKRedUV3bztsa46rS2fk0bxu2mw+2JS0SFPU+osVBD+/oyABeqNp6N49oiKvsTBg1Gmi20PdJpu3IYocJvI/GISh3rGE8FhCbsdhr4Zzmi6BJRqZYZF1Fl/EkephuBAvwwHTvI5Kud/sAQqjcn5sNk9AzMOEZ+mA7V+yBzH6EiquLNi/Ytm3pjY976AbgfpkuRL3aAjI3N9PuJR1TNVledJ24vKlRj2DJ+RGUeb3kH0LyxQ7ltOqMqGhIjY3W0uUVUhf2qWNmfL/zZO78EePEH8Cvb8wT1ARt3ZvbvrwCssNsq18P6YoyiMz8Fr57/Fly8YH+egB3u9xFRsZGJIXn7CQAeURXmSaJzEvhTBltE1a4n3ILptsInz8Or9y7Ynye0noXIDhImoir7UBdEcf5QoWINjHFOaRIrJzs14qhyzluoJF/kYuR2BizaMtytn215oN9pEXAiI2EnIZALZqnbSUI1RY6bOhljTEUumKVuJwlVDO8I1GfqZAwEi7XZXDBL3U4SqhjeEajP1MkYCBYSKvrMiz+1yJn8MXOtQdi6ItWUywWz1O2kiMqf24OtkToZYwCbC2ap20lCFcM7AvWZOhkDwUJbP9r6+VOLnMkfM9cahK0rUrT180cqbg2KqOLi32vvJFT+cOaCWep2OgmV//RTDUKAECAE+kUA/Vu/E8ee7a3H9z/4K+izvd4GNgUNEbb+k5gLZqnbycZPQuXP70HWSJ2MMUDNBbPU7SShiuEdgfpMnYyBYLE2mwtmqdtJQhXDOwL1mToZA8FCQgUAqXODhCqGdwTqM3UyBoKFhIqEyp9a5Ez+mLnWIGxdkWrK5YJZ6nZSROXP7cHWSJ2MMYDNBbPU7SShiuEdgfpMnYyBYKGtH239/KlldKbPV2H/8+tVg7Owsr0G8w+Z2t+B1f0LUJd+42NYO77HfzBTVsNVqHYu7YeFK4Lxp6/B7XMAq5cAls8dmDJU7ObYMGvhBACznGv/sAFLsyPY5s0/vQK3Ls/DgwNFz8/ORbh2exmGxIT+IiomNGt70cmyO9PXsHHmEIxuAkDhPHqovtlcgqde2QYYODkmzVlUqLhzqbjxRSJDPFHMoFkUa5HiE1vhtvjebVh+fNKz7defq527A130+xEqD6JjgO1cWoW7M7swYgkTtFEVI84WwOl1WL8z7FXMj0rdS9uxrRzOJEZMxF4DuDjgqKA7Qu0WMD6WNRqxqkWpEv2ZBESKWYDbWdo4pULFJ3AWFk8DrN852jGiAmBCBaf2wtssrNZEVSyaehVW4OzuIVggoZI8z0ZGHoXaVv+dzQ145Phwty/xhAoA6q0e2xbNwdb+BYBERIqECnZgY/NhmD++BwpH+LAnoTq3DFCco6hnVWxrOAJ4fQ32Xd1PQqV4rlmo+JYaO/sLIQXDbhOPNITxC+eoKWz3RORxO6c6omqg6FuoDvAVTIyqGFE+mivOroqDToqoHCMqLlTDOySNLWO4A8sjdIlMY9uk6x+3k4TK0Zmq0wC29TtX3jiUty48CmiiKXYbSELlc95CQmUSD9yBlYjqo72wcmcEo5tpRae4nSRUYwtVfS7AoqojW3U0VRxvUkTV8j2XK+jUtiyhoxPcgfkIykucOXZtb7o9DT3YDu3jdpJQjS9UdVTFmpBXMBIqn4hKOAy2PEHYubQEd0/Z3q918JSBVsUdmA1cjubZv/AtYOvJQrJ2klB5CpXiLIbVi4TKU6hY8fowWD2rKreG95aG/x6obx1Aharg33U4qnkqwx+EpiBWqJ3VE4wpfZ7Q42G69DJdfvDJCLF1pHIitZz4WrhvFifWHk7GYtMsveovTUzrvKXPacFvSnlvmohefN0/cAxdjgUaXId36dLPg08P5rg5k0eDVLRGgLD1J0MumKVuJwmVP7cHWyN1MsYANhfMUreThCqGdwTqM3UyBoLF2mwumKVuJwlVDO8I1GfqZAwECwmV09/6xUDfvU8SKnesBl+ShMp/inLBLHU7Saj8uT3YGqmTMQawuWCWup0kVDG8I1CfqZMxECy09aOtnz+1yJn8MXOtQdi6ItWUywWz1O2kiMqf24OtkToZYwCbC2ap2+kkVDEIRH0SAoQAISAicPLEc/X/PnD//v374i/fff+3cOLYs70hlrqy9wZEgIYIW39Qc8EsdTudIioSKn8HiFEjdTISZuEQSJ0bJFThuDHxllMn48QBm4LbMFfMUucGCZXrTCdQLnUyxoA4F8xSt5OEKoZ3BOozdTIGgsXabC6YpW4nCVUM7wjUZ+pkDAQLCdUUbHFJqGJ4R6A+Saj8gc0Fs9TtJKHy5/Zga6ROxhjA5oJZ6nYOR6ikTwxjn8aVP6f75PeegE9/81nFc+QzqnXG27L4NGVlcSUj/9Z3LQxF7kSA1UsAy+dYorLmx6dsDKHp2qcNs5bt4mevFR7B0yvw88dG8CPp88QA9ffUNeVvXZ5cVmo/Oxfh2naVrVwAOOa34TsLFc/GUdqDCQyA3Zl4/jn5m+kqGes+pYwqjXjZAK3Jp0kX35X0seujQmVK88QXCRFPn7KxDe/QP4qZ8I35Fq8q3OTFzsJDbfkOg/eo6mqnmtyh9LUZuMbShHn013fRTkLVMqKYCLAahQG2c2kV7s7swugVgBVN5o8yOcEWwOl1WJcyJX8NG5e2AWAEoyuGqIo532v3YAbWYf0xFkXEhL7vqcQWgcqBTOmyCmwALharvE/Z/u2YZIsYH8uxNOJTi1Il5DPv6TL3+JYPbzFupz5d1hQIVRn9XH/mY1g7vqdCGk+7hAHGhApOVWGnJuphwL0KK3B295CS0r0UqsNH7sFTz683Ibeyjdk68jHsXTsEo8yEyiUV+c7mBjxyfB6gWEW3rdtiXvbB8D4WtAeMj3Xn9daNLYJzsLV/AUArUlUN3/JBrcQWsUaMpzKiamNbqrJtAjFiFEJ1bhlASufOe2oSQe67ul8vVOdm4caZQzC6qUZVPNPtC3CX/T4roeJbanxrXibbZPi5lA3sXRNoHuOjNAThHNXpbNO3fEB7cTunNqJqo1qs2h8eBdshIQYYF6o6bbYYVbGJ/2iu2LK1E5BWEdW5eXiwIoh4psAjsbXjUDpilkLlkq+NC5VL2YCeNaGmMT6qw3CJTMU6vuVDmY3bmYlQlRNiOldq4McAq4WqTufOV3Y5rbZVqOqogDsbj6bYgWDliCRUBp8goTKKRbFQ7oWVOyO3iNO3fCiVcnrwmYFQuYoUmwcfoQK+z2dR1ZGtOpoqdtRsa6g5TD/MIipWQIiqLsKoONcqz9JyFKoKrytuzzH4zajT9iagc02iaYyPzRiExc50IyoN2Ld8WGtxO6dcqEpSu28TMMDEiKoWpOJtiialtk2o6qiK1RXHl6dQ1aJvuvUrxH8J7p5ag3nYgKXZEWy7lH0orIOFbh3jY9m/HM2zf+FbOv1TGN/yoa3EAwR+szmVh+njXF1ixKidhTuAYfXSRlRnfgH7LgvvPfhhpnR7mKlQCVGmLNzcEQ/BvSXhqr0+CFYXIfxmN7zb9dcDxsdS4K/DUc1TGR55SmLlW74/U6wtoXZWTzCmUKjk1+EiSrYHl0bApJfp8oNPRoitI5UTqeUAQH6ZLrwGVlZC+XFqOeJp2t7gZCxi1OJmdl2itemGz6fshDyu527MmAmPj4s+NRG99Ar9STj2xKfwAf8DCbT8ZG9Vs3+Z7ssbN2fybZXKMwQIW38e5IJZ6nZ2epnuTwtypnEwc62TOhld7eyzXC6YpW4nCVWfrI/cVupkjAFfLpilbicJVQzvCNRn6mQMBEvHQ+YYo+q/z9S5QULVPyeitZg6GWMAlwtmqdtJQhXDOwL1mToZA8FCEdUUXLSQUMXwjkB9klD5A5sLZqnbSULlz+3B1kidjDGAzQWz1O0koYrhHYH6TJ2MgWChrV8uW78YBKI+CQFCgBAQETh54rn6fx+4f//+ffGX777/Wzhx7NneEKNVvzcoWw0Rtv7Y5oJZ6nbS1s+f24OtkToZYwCbC2ap20lCFcM7AvWZOhkDwUJnVLmcUdHWL4YL+fdJQkWYmRBInRsUUflze7A1UidjDGBzwSx1O0moYnhHoD5TJ2MgWGjrR1s/f2qRM/lj5lqDsHVFqimXC2ap20kRlT+3B1sjdTLGADYXzFK3czhCJX1iGPtMq/yJXPlTxEiiiTqDbekWTx0AuLVTuYgmM7PoPPKnjN0TWkzKAV3JyL/1XY+rsBtg9RLAspLmPlTZSWGC9WPDrGU7+yDxG1VmcIVH8PQK/PyxEfxI+jyxrfxL8BL8FH56Ux5h/Wlsy6e5MZt0v/ezcxGubVfZyoXGmO1FhnLJxsn4QXehkgDFB213JuE71RbRqAVDypLSiJftm+01+dTEps+zr4jbBLJpf6jfWUeFypTmic+hiGeosuN4WcA6KGbCN+ZbvKpwk/lg4aGuvCB4Kq980tBhELna6ZbcQZ9aCxtDl993E6oC+F1YqTJ09JUp+e7MLoyMyUzLfGlweh3WNemyAEYwMqXvYqR47R7MwDqsiwlI/2EDVj8BgFdGsG4QyCLT8u4MwJV1mHlPyNbSBf2e69rJWDmQKQVWgQ3AxcssL2Kosj0b3ENzuAOzTjSLVCUwei54lq/FSlgoFd/qaipup09ev8SEqohOgG0bDpQ4WlIFcaAxwIq8fqeqsFMjGjw1exGC6vL6HbkHTz2/3oTowgyX2Ww+hr1rSkr3QqhmYa4Ia3VRVZVMsgqHUxQql9TiO5sb8MjxeYAi6/W2NUPPOGWLxLAD+8H4WA+3FhO2a5iDrf0LALYFy7e8GNW+DvCqIUXXuPDhdk6xUKmg9RVRwbllgCKxqSoaTWLHfVdNmZJn4caZQzC6qW5DeebaF+Au+30ropqF5YPbZeJNVSCL1NxzcPvU3eL36QkV31JjZ39sRkOVHdfFwtbDHVjoXzjmcNr+e5ZvzkBd5skPF9zOHISqnhAcYAywOlOymM6dR2xcMM4dsKd0F9K5l2ncy8y2ZVp3gA2TUB3fU7YrCaSQ9bbKIJyuUOFniI1Q9V3Wz7EmVRrjo3YxRqJNsY5LJCuWb/OvHyRwO3MQqhrL0lhbSIwBJqZ0lydNTpOtzZR8aRsOn2NnLDwq4M7GoymWRVmTKbna+i0zUVMFUhBH/jsSKj7hKs79ONUkW8H4KI2l4MJeWLkzgtFNfFEGz/LlYnoUZthZKbgsFO5I4XZmJVRQRiTiuZWCJQaYKFSSaBzZKrdfVXRlFyqAgiTVWdVFGFXRFIuuEKFiR6d1VLUC8NoI4PU1mGcp5q0HqO6kCVXS5QraZcvCb0b7LhvK7i7tYnxs2hYWO9ONqDQQz/LiZQbfoSDPZXzsxu2cWqEqHf76M9W7kgq1XoWqFg3WuCaltu4wvYioxLMW9t/i6oQLVS2QrKpIloSFqrbJdOtXYL0Ed0+twXy1xd3uuywT+4H94A7MuSQsWNVRArtw0D+FkaN/fvRgLi9G/CVAPouFC6S4nVMrVDxqAbh2m22p+P83zxV0AGKA1c7CSW1YvbQR1ZlfwL7L1Vjq8azLYmOIqJau7oM14bGjligpC5WIR2tbUYr3vSXh2UV97qhuQTqWdfGqCZbB+Gi7yeYckcTKcvOtLV/gLPhQbXvzptAlssUgQ+2snmBM5zsqYWUpgcL37UbALC9xy2cFlROp5QBAfpkuvAYuRKlZCeWX5eWIpZfp4vild0XCQ9SaEf2eIWBEc/k9TsZirS7OEdnz1ubHNG+hyrpYM5kyZszUOddE9NIL7Sfh2BOfwgef8XFj5f8InoK/h1taPvXPN5djgQbxaXyZ7sknN2fybJSKFwgQtv5EyAWz1O3s9jLdnxfkTGNg5loldTK62tlnuVwwS91OEqo+WR+5rdTJGAO+XDBL3U4SqhjeEajP1MkYCBZrs7lglrqdJFQxvCNQn6mTMRAsJFRTcH5JQhXDOwL1SULlD2wumKVuJwmVP7cHWyN1MsYANhfMUreThCqGdwTqM3UyBoKFtn609fOnFjmTP2auNQhbV6SacrlglrqdThGV//RTDUKAECAE+kXg5Inn6gYfuH///n2x+Xff/y1QpuR+AQ/VWuqrZihcbO3mglnqdjpFVCRUMVzIv8/UyehvcfcauWCWup0kVN25PpgWUidjDCBzwSx1O0moYnhHoD5TJ2MgWOjWj279/KlFzuSPmWsNwtYVKbr180cqbg2KqOLi32vvJFT+cOaCWep2klD5c3uwNVInYwxgc8EsdTtJqGJ4R6A+UydjIFjojIrOqPypRc7kj5lrDVds+be763aLBBYAq5cAllm2n+flDxXL/Q/vE8yu+OjK2TBr4cQ+tv1GlcykzoRctfr0S/AS/BR+elPsBf80d5ex+9T1s3MRrr0HsKDwQP52u/KZ6h4z5pjmqacHn/qsNGqnrs7kMwlUtkQAxdaU5klMJ365zOLTTp7BehDIGZiYk5pTFDPB5lbGmQo3yYEHmgDE1U635A58dtrZdkLNW29bP544QZ8+qBk+DlgoU6e/XTu2lciYUmBJySxMQlViqM2mkii8bnxsBLoWJZMgTZlQ2XNZ7pRRuJC9KRQN+hGqguT3YAbWYVfJ80cRVaipa7drczqX1OI7mxvwyHFbRMX7RERvciZ37slNqJrks9tFqrE52DJlBJ82oeILkyapMOPU+qNrsPx452lAG+hBqHj4x7IKtxOSklChc9BbAbPT8fRL7mcm+q2fGPIfcktr3pt1YRpyFirWvZCqzZhrbwqFSp/bkHFKyaMZZorqY41uZ1Rs8opU6w9rMyeTUAWcPaVpXKjcD8LtQiWmva/S3U/OzF578hIqIY9lVkKlS9r7+SosffkCrB3f0+t8mBrrGFGJqajpMH0iM2bpZHJC5R+hxcbG5gDOf3RfLMp7YeXOyBxNTmNEVUeTTRb0VkbzwBPcSaikDMaV6l6nM6rAU2Zu3uUK2jU9uD2iyvCMqrj924K528twwHR7yqbGKlQ7sLH5MMxPKAoRmYJHjuWcqrd+TRvVnLPb3lN3Yek1gIvVDfEkCN9BqHTpvqshW66uccAmYfZ09mHF1uZcFRziKmkTKn7r5yp6Q0bbjY/ta3jjLbdFqCZ5+Ox/5IIJFUBpM8DiaYDdmZWJbfuYLR2ESoWCtn6xHRJ1uvowWD2rKufu3tLt+gYHe0eFPUOJjYVr/yhmhfBch6Pb7bM47TMN67MFfTuuY+1SDrWzei9mjqjUm89lONBlQJ51Sag8ARtycZyMbPS6SFi4DRRutrS2mt5hDRmYTud6vLJ8Y9p+tf4kHHviU/jgM0tnEbFzORZoRm6+dCns1jxVCD39PQqV21DdnMmtLSolI0DY+jMiF8xSt5OEyp/bg62ROhljAJsLZqnbSUIVwzsC9Zk6GQPBYm02F8xSt5OEKoZ3BOozdTIGgoWEyuUP1mOA79EnCZUHWEMvSkLlP0O5YJa6nSRU/twebI3UyRgD2FwwS91OEqoY3hGoz9TJGAgW2vrR1s+fWuRM/pi51iBsXZFqyuWCWep2UkTlz+3B1kidjDGAzQWz1O10EqoYBKI+CQFCgBAQEej2PSpPLFNXdk9zJ1qcsPWHOxfMUrfTKaJy/l6PA09SB8zBxGhFCFt/6HPBLHU7Saj8uT3YGqmTMQawuWCWup0kVDG8I1CfqZMxECz0PIGeJ/hTi5zJHzPXGoStK1L0PMEfqbg1KKKKi3+vvZNQ+cOZC2ap20lC5c/twdZInYwxgM0Fs9TtJKGK4R2B+kydjIFgoTMqOqPypxY5kz9mrjWM2GKfFy6y/04D0OQDAAAWzUlEQVT2G9iuNoUuZ+YjTwkmjsA9gWvocfu272Wn8slknsii7DMOBp0jqva3o+2GkFD5Usy9PIYtlrABLNmD3EeRVkkMM3v6q3RsRe3EkjvUiYYnmdJBvvTo8DJdTEDqNmk4YG7tUKk2Ahi2LimwpiW7jCs/MMzyEaoq+/WdFbilydf3zeYq3Di4DPMPuSLbb7luERVLDeSZiBAlRr/2ZdUahm0uSUV9Jh3DLCehKm3VpfTagdUzd2FxgglH1TnsJlQs//zaLmzf3K7axfevKDF8WEZlJQQwbO1CNT1p2n1ogWGWlVCxZGq6dFjMz798YaIJR3sVqvKQbaY5iC0ObZv89DrCoMTwYRmV7VGoKpJewRebaYId5aM1RXs6SKB2clNaPswWsF/AvstxL1u6RVSaecISFDoDlg4HBjNSDFuKqPzP9XKLqACqyPqxa3D73AEo7L+6D9bYf0f86V2oiihr92xppOYHc6aIWCTfNYYtnVH1LVQ7sLH5MMwf3zN47mDcEA0od0oAK9trsO/qftg6chuWH49rYgehKpX3+jMfS3tX5gxvz8j/JproA1hcaNLrHcPW5dZv8b34pJwk8hhmtoiKOfT6o2vRndgFL9ROqRF2m78A66cXYfEKwNwA3th1ECoA/RkVWB8P+gHmMgVUhiOAYYu9o8rtaQLDDcPMKFTGG7Jh8hG1Uxk2fx85FE50Eipmm++rVV/AhjntwxyVEVvsZbryEnmY1oUZlZmPupfpyhgSws3b7wYmxJ2Fypc+3oD5dpBxecLWf/JzwSx1O0mo/Lk92BqpkzEGsLlglrqdJFQxvCNQn6mTMRAs1mZzwSx1O0moYnhHoD5TJ2MgWEioXC4NYoDv0ScJlQdYQy9KQuU/Q7lglrqdJFT+3B5sjdTJGAPYXDBL3U4SqhjeEajP1MkYCBba+tHWz59a5Ez+mLnWIGxdkWrK5YJZ6nZSROXP7cHWSJ2MMYDNBbPU7XQSqhgEoj4JAUKAEBAR6PApYn8gU1d2f4snV4Ow9cc6F8xSt9Mpojpx7Fl/BhhqpA5Yb0AEaIiw9Qc1F8xSt5OEyp/bg62ROhljAJsLZqnbSUIVwzsC9Zk6GQPBQs8T6HmCP7XImfwxc61B2LoiRc8T/JGKW4Miqrj499o7CZU/nLlglrqdJFT+3B5sjdTJGAPYXDBL3U4SqhjeEahPIxmxL3zCouXz0e0vXRafpz24DaufzMJyAokNbHCbHVj3hU99KjH+2V6xn/oTvlW6LZ75EiJ9FdTLTmWM6ld8z3x/Gy7/WrTWxp9+yN5dqBQnwL6xnLqy9wN7mFYwbLFvpsPpKkUSHx6fW+Xfa+Kq5cOYFbRVDDP3dFlVQgQAaPlAhWPMxBmonVCOf5ctQrrFh9nw0ZyQXQop3/OsdROqVnLGcvBgyWSCA9azhRk1h2HrkoWmFQmYxKhF3DSBxjBzFypmfyNWtSgNJIEpaifPknxnBW5pUrd/s7kKNw4uw/xDfJ4TEios2aiOui6ApUn5+KPGsPXJ6/cVS+1tzZr8NWxs/h7mj8dNTNkVdQwzP6GCMmHn7Ai2i+30HGwhC3fX8bvWR+1kDRkTOuzA6pm7sCgJWDJChUdPJFSuNOqnHEZG90zJZ+He7AKsW8+u+hlz7FYwzLyFihkkHIfE3O6J2KJ2VoW1wcfnq7D05QvKljApoXob9m5zUpeWYhPjClhsAqfYP4atXagAykNhdmBczWmkg99JYo9hNpZQCWnkMH+YlK2ondK55G6RJbnc5rFLhV/AvsvLIMfOSQmVsuo67MedAZvUDE5RPxi23hEVCVW9lZvxySBdnN/thZU7Ixjd1N8UTpp2GDea8VS3nY9VFyvMp6/ug7Vz6hY/KaFiERVX3tJU7NzKHbBJT2X6/WHYup9RzcKNM4cG42QhZwbDzB5R7cDG5sMwL92SMQfeKtOg8/OqAQg+aqcAcnmrC0VUte/qftg6cluTtj4ZoSqV996SbAQJVUi3sreNkdHl1q/eqhieJsgrr25LEM/+cXrGMLMJFXPo9UfXBCdmPjECeL1ZvPlTDuzZzjhj96mD2ik1Vt1enl6ExStQim6rs2SEih8aQvNYkLZ+PtzpvSxGRuwdlepM9XupVkTASNqOpns3aAINYpgZhUq9IbOkQOcPQmOKFWqngjU+5pSEihmnPPjEDg99AZsAV6emCyO22Mt029ZEfVldoBX+JfKkJsXMR93LdGVUBW58m8x/J59JtV+txzmz8vY7B+Ft0AjPBzZ++sLnpLwicD/eZAw8nhSazwWz1O0koUrBmxzHmDoZHc3stVgumKVuJwlVr7SP21jqZIyBXi6YpW4nCVUM7wjUZ+pkDASLtdlcMEvdThKqGN4RqM/UyRgIFhIq+hSxP7XImfwxc61B2Loi1ZTLBbPU7aSIyp/bg62ROhljAJsLZqnbSUIVwzsC9Zk6GQPBQls/2vr5U4ucyR8z1xqErStStPXzRypuDYqo4uLfa+8kVP5w5oJZ6nY6CZX/9FMNQoAQIAT6RYD+hKZfPKO1lvqqGQO4XDBL3U6niOrEsWd741DqgPUGRICGCFt/UHPBLHU7Saj8uT3YGqmTMQawuWCWup0kVDG8I1CfqZMxECz0PIGeJ/hTi5zJHzPXGoStK1L0PMEfqbg1KKKKi3+vvZNQ+cOZC2ap20lC5c/twdZInYwxgM0Fs9TtJKGK4R2B+jSSEfsUsfXTwu1P8hbf/j64DaufzMKylIGF5wYUDCxSwgOsXgJYbqVcCgSER7NmB9Z9ilj/GeH254YB6u+jq59yfnoFfv7YCH50RR6krbwuxbqHiUVRLzuVT1PX384vWpqFM9/fhsu/FkewCNe298LbRYbo5qfPb8R3ECrLN6ULcupTfaeu7L4EmWR5DFssuQOo82bIRFMTVyxvSg3F2xhAyijdXGCYuScgrTK3MFdmQi4KeIWBnE/At3w3JqF2ApKsochVOCf4tb58yY2ZJuFLt2HXtTsIlWYExYSIWVbbZXDAerIsw2YwbF3SZbVWdtOiIxG3cjqTGDERew3g4uV5eHBg84Jh5i5UzLBGfGpRsmZm8i0/PnionTwn5x2WsKI9T99srsKNg8tV9uTG1l1FlBMQKrf0OS6AjT8dedfEsHVPQDoPX9Xp3eUEsw3CX8PG5u9h/vgB4BGWLQPRzuYGPHJ82oUK6szK28V2eg629i8A2LIs11tDx/JjUhzjRtGsMfPMDqyeuQuLkoAlGlEVZP3wqFaNRWydABtzMnKvhmHrndLdKS0WPwKIkwaq65xjmPlFVNVohDNBLH1cUcO3/BhGo3ZWbWoTCH++CktfviBvZw1bxYFHVKW6WleOCghXwMaYi+yrYNjahYofhDPBOQv3Zhdg3elciQtV+NxuISYYw2wsoQJwijJFe1yi0i72o3byxlvHN2x+dRmxU4yoCuOEjMkWRJ0B6zIrmdbFsPWOqEio6q3cjG37pvKtOL/bCyt3RjC66RBp+pYfg98YN6Qt/ZlDMHqsuhBj28Gr+2CtdTmWoFBpw0UDmO6AjTEbmVfBsHU/o+LZfx2cjB/CXgFw2uYMbI4wzOwR1Q5sbD4M89ITDebAWzB3exkOmG5CJQx8y48HIGqn0GwZ3QGsbK/Bvqv7YevIbVh+XO03OaFy3/YxU30AG29K8q2FYety61eLjeFpgrzyVlsCB4fcubQEd0+ZDubjzRmGmU2omEOvP7omODHbJo0AXm/s5Fs6/Zsi3/Lj44Ta2RLPBVg/vQiLV6AU3VbXqQmVJUe9DlY/wMafmBxrYthi76hUZ6rfS7W2gIykb8PebUF46gNh9ayqPMO6t6RblePPEoaZUahU3lv8gD8IlfD1Ld8RKtROpX3tmDVils7zBI/zKYqoOrINqW4kI/Yy3XYWpb6sLsZgOjhv3gU1Q3XbPoZFxty62YEtD5p5cwVufJvM/1G2t/1q/Uk49sSn8MFnruX7wc9XqMxPFTR/fcD4MNyX6eNRyxuw8brJshZh6z/tuWCWup1s/PQpYn9+D7JG6mSMAWoumKVuJwlVDO8I1GfqZAwEi7XZXDBL3U4SqhjeEajP1MkYCBYSqim4bSehiuEdgfokofIHNhfMUreThMqf24OtkToZYwCbC2ap20lCFcM7AvWZOhkDwUJbP9r6+VOLnMkfM9cahK0rUk25XDBL3U6KqPy5PdgaqZMxBrC5YJa6nSRUMbwjUJ+pkzEQLLT1y2XrF4NA1CchQAgQAiIC9DJ9SvhAEZX/ROaCWep20tbPn9uDrZE6GWMAmwtmqdtJQhXDOwL1mToZA8FCZ1S5nFGdOPZsbxwiZ+oNylZDhK0/trlglrqdFFH5c3uwNVInYwxgc8EsdTtJqGJ4R6A+UydjIFho60dbP39qkTP5Y+Zag7B1RaoplwtmqdtJEZU/twdbw0hG7FPE1kSj7U/yFt/+PrgNq5/MwrKUgUXzmdoiJTzA6iWAZSXlUuszvZayoUA3O7DuU8T6zwK3PzcMUH8fXf2U89Mr8PPHRvCjK7JFfZbXpWT3slP5NHX97fxiyLNw5vvbcPnX4vjNnyI+u3sIFiRbx8v/2FmoVCNYip35h8y0Sl3ZQzlMH+1i2GLJHaAQCiHfiCETTT3nYnlTJhrehkh+n7J9AGNpA8PMPQFp8734VsaZCgM5nVjo8rLRqJ2GzMd1K0XuwTmBHz5ZaPRlfaa2m1CpWVUdEj3ggPkMn8qKCGDYuqTLaq3sqnjxDiXiVk5nShLBhOk1gIuX5+HByiGMWZilsuHnF8PMXajYWBvxqUWpEmV9AtPQ5f22uDZ+fLO5CjcOLgtBSEJCVaysHx6FJtTUpFFSuIYSIzw3p7YHDFv3BKTz8NWl/bBwxZYB5WvY2Pw9zB8/4JS+fGdzAx45Pg9QJLfctiYr5WUfnMBMYZj5CRXUmZW3i+30HGztXwCwZVmut4aBylcYonaycsYUXjuweuYuLBYLDf9JSKiAIqoJuJJ7FxgZvVO6W8+u+Lj4WY5LWiefsu52dymJYeYtVGwwwpmgU/bo0OU9bv20Wc8/X4WlL1+AtVZG6AVwy+sXe+tXq/AIttl/2/LD+Sh7F+ZlXBdzOrtQ8YNwJjhn4d7sAhi3ZxLGXHxcDkl9yk5mIjHMxhIqAKcoU7SQn/s5CdsY7aN2ilv653eLdO7lWTObsyojtjQlCUVUJbgzcI2nfFYjLA3XnAGbDE+nqhcMW++IymHhKYl8CEY3SahqMhXnd3th5c4IRjcdIs3Q5T0iqno+H6suVth28Oo+WFNubPl5XAIRVUnQ6898LIWE2tBRkAPMmaZKOSZsDIat+xkVz/7r4GTsCLk4zwLruVN9suFRdhLwYZjZI6od2Nh8GOZbW6ItmGOLt+l2sxWZhCxfdobaKYypDECgiKr2Xd0PW0duw/Lj6mwkE1GRUE3CkXz6wMjocutXbz0MTxOa8QhbAgeH3Lm0BHdPrcE8bMDS7Ai2LdFaXdbyzMUHF1tZDDObUDGHXn90TXBihskI4PXmiQ7f0rWeLBSDCl2+sRy1U7OtWz+9CItXoBTdFojJCBXfh9PWry+n6doORkbsHZXqTPV7qZaoaG536wNhdQtYLmj3loRV2adsV1CQ+hhmRqFSb8iMN2ZNxCnhG7q8Yjdqp1KeR8l6gWWFExIqNlz5wSce/vsCFpinU9W8EVvsZbrtLEp9WV0gZjqPat4FNcCato8+ZcNNk5mPupfpyjgK3Pg2mf9Otrf9av1JOPbEp/DBZ6HK6/H29jsHIW3QSOBlui+FvAHz7SDj8oSt/+TnglnqdrLx06eI/fk9yBqpkzEGqLlglrqdJFQxvCNQn6mTMRAs1mZzwSx1O0moYnhHoD5TJ2MgWEioPJ8nxJgHrE8SKgyhhH5PQuU/WblglrqdJFT+3B5sjdTJGAPYXDBL3U4SqhjeEajP1MkYCBba+tHWz59a5Ez+mLnWIGxdkWrK5YJZ6nZSROXP7cHWSJ2MMYDNBbPU7SShiuEdgfpMnYyBYKGtXy5bvxgEoj4JAUKAEBARoJfpU8IHiqj8JzIXzFK3k7Z+/twebI3UyRgD2FwwS91OEqoY3hGoz9TJGAgWOqPK5YzqxLFne+MQOVNvULYaImz9sc0Fs9TtpIjKn9uDrZE6GWMAmwtmqdtJQhXDOwL1mToZA8FCWz/a+vlTi5zJHzPXGoStK1JNuVwwS91Oiqj8uT3YGq5kbH0et0jbDrB6CWD5yBbsf369shHLQiN/Ttj8fe3BQmbNztL+jDBAK+U9N039nHPrE84lloc/UVOjTwYbGzfaduo/LSx+glqt45qPcFxrOwuV/M10PLebqzONa1DO9VBsTdli+DfVa2cTvhdeiFg7BwnD2Zz8IZ1ZQDGrkhgw6W4JcYWb6qT69GENpqGdWoe+q536PH0svbA+accI2HfjxVTvYea+k1CJ+b+KrKqFI9yDs9r0OqUBOGBhDM2hVTu2VfRjSuTA5u41gIsV6XYurcLdmV0YVfndyqy54g9rbwvg9Dqs35kMWUPMoRsfm8ixFplK9Gfek3PeYRmPmYjp8+SFsM5ni2tOu65bkLCs231b00GozHn93p6Rk5KKg3YjRt9m5tGeDVvMgRhCO5sb8MjxcnVkQgWn9sLbLAefJqpi7b0KK3B29xAsTL1Q8UV4BNtFZDEHW/sXABSR4imk1pGsPhtfzcN8K6FnWI7ifmcWqoIbVeJYFlVehBE89eHRiURSHJXOQiXla+MGgXm7gAMWdsKmuXUztnzbgZ05NegUQnVuGaAgqFqvSZzJMulmIVQMGiHtmHb7hiZtjcc+3O/sQlWner8JADYhDmRiB6HSJCDlZyCWcw0csECWZtAsLlT4GSKHiQtVnZZcnFPmkB/NFWdXk94C9D2Nvny0RqaVUA3xUgG3ExOqIq6C1f0LYI0Y+56gqr1OQiWGhEV7T6/AtWeuw8LuWeMBLA5YIEszaDaIUNVhP4+q5DTkWQlVIdB7YeXOCEY3NdHpVAtVNe/PzMDolXUASzASwtU6C5U6KEZcOqMKMVV4my5X0K43TnVExboVI2X2fKGKpuqFKoczqiKa2II5dlFkuj01/Ts+dcFL4AGCPaLiZ5Jrx/fU51WuXOrDuJ6FqjS2fcjYDBUHrA+z8mzDiq2DE+1cWoK7p9aA3fBJQiUcpgJoUpZPvVDJUSRjF98Cqts8/dMEgY9sHq7ugzXDk49QzMX9ziJUwla/HB+/BXU/SuhqVyehKiZLOP132QbggHU1Kd/6KLb1YbD+TYx4MSKKVoGoQehc5nzIM4JiVth9HY5ulwIu/og3YSzSKH+a91Lad1dreyd6W8bHi9pZiY/6jqqwUXc5Vj9onYxYdRKqOvS/wuHAB40DNmRaD3tsbtjKr8lLi4QoSbjZKn4lnEVIb4DUcroHkcOGqxgdfq7HjdBEkjXvFQzFx7AiBhM+1xG7djkWaMovwrX3ABbqv1CQeVAvWhO0rbNQ+XLRzZl8W6XydqcjfEwI5MLH1O0koZoiH06djDGmIhfMUreThCqGdwTqM3UyBoLF2mwumKVuJwlVDO8I1GfqZAwECwnVFPyNLQlVDO8I1CcJlT+wuWCWup0kVP7cHmyN1MkYA9hcMEvdThKqGN4RqM/UyRgIFtr60dbPn1rkTP6YudYgbF2RasrlglnqdlJE5c/twdZInYwxgM0Fs9TtJKGK4R2B+kydjIFgoa1fLlu/GASiPgkBQoAQEBE4eeK5+n8fuH///n2ChxAgBAiBISNAQjXk2aGxEQKEQIEACRURgRAgBAaPwP8HO3Ix8ikM3hsAAAAASUVORK5CYII=)
