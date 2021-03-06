import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;
    

    constructor(props) {
        super(props);
        this.state = { menuItems: [], selectedItems: [], total: 0.00, loading: true};
    }

    componentDidMount() {
        this.populateMenu();
    }

    addMenuItem(menuItem) {
        this.state.selectedItems.push(menuItem);

        this.setState({
            selectedItems: this.state.selectedItems
        });

        console.log(this.state.selectedItems);
    }

    render() {
        return (
            <div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Price</th>
                            <th>Temperature</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.menuItems.map(menuItem =>
                            <tr key={menuItem.name}>
                                <td>{menuItem.name}</td>
                                <td>&pound;{menuItem.price.toFixed(2)}</td>
                                <td>{menuItem.isHot ? "Hot" : "Cold"}</td>
                                <td><button onClick={()=>{this.addMenuItem(menuItem)}}>Add Item</button></td>
                            </tr>
                        )}
                    </tbody>
                </table>

                <div>
                    <h3>SelectedItems</h3>
                </div>
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Name</th>
                        </tr>
                    </thead>
                    <tbody>
                        {this.state.selectedItems.map(selectedItem =>
                            <tr key={selectedItem.name}>
                                <td>{selectedItem.name}</td>
                            </tr>
                        )}
                    </tbody>
                </table>

                <button onClick={() => { this.setState({ selectedItems: [] }) }}>Clear selection</button>

                <button onClick={() => { this.calculatePrices() }}>Calculate Total</button>

                <div>Total: &pound;{this.state.total.toFixed(2)}</div>
            </div>
        );
    }

    async populateMenu() {
        const response = await fetch('cafe');
        const data = await response.json();
        this.setState({ menuItems: data, loading: false });
    }

    async calculatePrices() {

        const response = await fetch('cafe/calculatePrice', {
            method: 'POST',
            mode: 'cors',
            cache: 'no-cache',
            credentials: 'same-origin',
            headers: {
                'Content-Type': 'application/json'
            },
            redirect: 'follow', 
            referrerPolicy: 'no-referrer',
            body: JSON.stringify(this.state.selectedItems ?? []) 
        }).then(response => response.json())
            .then(response => {
                this.setState({ total: response })
            });

    }
}
