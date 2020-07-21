import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { menuItems: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderMenuItems(menuItems) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Price</th>
                        <th>Temperature</th>
                    </tr>
                </thead>
                <tbody>
                    {menuItems.map(menuItem =>
                        <tr key={menuItem.name}>
                            <td>{menuItem.name}</td>
                            <td>&pound;{menuItem.price.toFixed(2)}</td>
                            <td>{menuItem.isHot ? "Hot" : "Cold"}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Home.renderMenuItems(this.state.menuItems);

        return (
            <div>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        const response = await fetch('cafe');
        const data = await response.json();
        console.log(data);
        this.setState({ menuItems: data, loading: false });
    }
}
